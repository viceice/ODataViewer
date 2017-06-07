using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Services.Client;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml;

namespace DataServicesViewer
{
    public partial class Shell : Form
    {
        #region Fields
        const string ATOM = "{http://www.w3.org/2005/Atom}";
        const string META = "{http://schemas.microsoft.com/ado/2007/08/dataservices/metadata}";
        const string DS = "{http://schemas.microsoft.com/ado/2007/08/dataservices}";
        
        
        TreeNode NodeSelected;
        MetaData MetaData;
        string ServicePath;
        DataServiceConfigForm dscf;
        WebClient client;
        #endregion

        public Shell()
        {
            InitializeComponent();
            client = new WebClient()
            {
                UseDefaultCredentials = true
            };
            EntityTree.AfterSelect += new TreeViewEventHandler(EntityTree_AfterSelect);
            dscf = new DataServiceConfigForm();
            txbQuery.KeyDown += txbQuery_KeyDown;
            intellisenseWPFControl.SelectedItellisense += SelectedItellisense;
            intellisenseWPFControl.ToolTipChanged += intellisenseWPFControl_ToolTipChanged;
            txbQuery.DataBindings.Add( "Text", intellisenseWPFControl, "Prefix" , false, DataSourceUpdateMode.OnPropertyChanged);
            WPFHost.DataBindings.Add("Visible", intellisenseWPFControl, "IsVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            HideIntellisense();
        }

        void intellisenseWPFControl_ToolTipChanged(object sender, IntellisenseEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Intellisense)) return;
            IntellisenseToolTip.Text = e.Intellisense;
            Point newLoac = new Point(WPFHost.Location.X + WPFHost.Size.Width + 5,
                                       WPFHost.Location.Y +5 );
            IntellisenseToolTip.Location = newLoac;
            IntellisenseToolTip.Visible = true;
            IntellisenseTimer.Start();
        }
        void IntellisenseTimer_Tick(object sender, EventArgs e)
        {
            IntellisenseToolTip.Visible = false;
            IntellisenseTimer.Stop();
        } 
        void SelectedItellisense(object sender, IntellisenseEventArgs e)
        {
            if( !string.IsNullOrEmpty( e.Intellisense ) ) 
                txbQuery.Text = e.Intellisense;

            txbQuery.Focus();
            txbQuery.SelectionStart = txbQuery.Text.Length;
            HideIntellisense();
        }
      
        public string FullPath 
        {
            get 
            {
                if (ServicePath.EndsWith("/"))
                    ServicePath = ServicePath.Substring(0, ServicePath.Length - 1);
                return string.Format("{0}/{1}", ServicePath, txbQuery.Text);
            }
        }
        

        void txbQuery_TextChanged(object sender, EventArgs e)
        {
            tslbl.Text = string.Format("{0}/{1}", ServicePath, txbQuery.Text);
            
            ShowIntellisense();
        }
        void txbQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && WPFHost.Visible == false)
            {
                btnGo_Click(this, EventArgs.Empty);
            }
            else if (e.KeyData == Keys.Enter && WPFHost.Visible == true)
            {
                txbQuery.Text = intellisenseWPFControl.GetSelectedIntelliSense();
                txbQuery.SelectionStart = txbQuery.Text.Length;
                HideIntellisense();
            }
            else if (e.KeyData == Keys.Escape)
            {
                HideIntellisense();
            }
            else if (e.KeyData == Keys.Down && WPFHost.Visible == false)
            {
                ShowIntellisense();
            }
            else if (e.KeyData == Keys.Down && WPFHost.Visible == true)
            {
                intellisenseWPFControl.SelectedIndexDown();
            }            
            else if (e.KeyData == Keys.Up && WPFHost.Visible == true)
            {
                intellisenseWPFControl.SelectedIndexUp();
            }
        }

        
        void btnGo_Click(object sender, EventArgs e)
        {
            QureyWebBrowser.Navigate(FullPath);
            tabControl1.SelectedTab = tabControl1.TabPages[1];

            try
            {
                client.OpenReadAsync( new Uri( FullPath ) );
                client.OpenReadCompleted += new OpenReadCompletedEventHandler( client_OpenReadCompleted );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }
        void client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null) return;
                
                XElement xe = XElement.Load(new StreamReader(e.Result));
                IEnumerable<XElement> rows;

                if (xe.Elements(ATOM + "entry").Count() > 0)
                {
                    rows = xe.Elements(ATOM + "entry")
                                 .Elements(ATOM + "content")
                                 .Elements(META + "properties");
                }
                else
                {
                    rows = xe.Elements(ATOM + "content")
                                 .Elements(META + "properties");
                }

                #region Build DataTable Columns
                DataTable dt = new DataTable();

                if (rows.First() == null) return;

                foreach (var colm in rows.First().Elements())
                {
                    dt.Columns.Add(colm.Name.LocalName);
                }

                #endregion

                #region Insert Data to DataTable
                foreach (var row in rows)
                {
                    List<string> colms = new List<string>();

                    foreach (var col in row.Elements())
                    {
                        colms.Add(col.Value);
                    }

                    dt.LoadDataRow(colms.ToArray(), true);
                }

                #endregion

                dataGridView1.DataSource = dt;
                tabControl1.SelectedTab = tabControl1.TabPages[2];
            }
            catch { }
        }
        void MetaData_ReadCompleted(object sender, EventArgs e)
        {
            EntityTree.Nodes.Clear();
            EntityTree.BuildTree(MetaData);
            EntityTree.ExpandAll();
            
            intellisenseWPFControl.Start(MetaData);
            this.txbQuery.TextChanged += new System.EventHandler(this.txbQuery_TextChanged);
        }

        private void HideIntellisense()
        {
            IntellisenseTimer_Tick(this, EventArgs.Empty);
            WPFHost.Visible = false;
        }
        private void ShowIntellisense()
        {
            SetItellisenseLocation();
            WPFHost.Visible = true;
            intellisenseWPFControl.ShowIntelliSense(txbQuery.Text);
        }        
        void SetItellisenseLocation()
        {
            WPFHost.Location = new Point(110 + txbQuery.Text.Length * 10, txbQuery.Location.Y + 30);
        }        
        void OpenDataServiceConfigForm()
        {
            dscf.ShowDialog();
            this.Show();
            ServicePath = dscf.ServicePath;

            if (ServicePath.EndsWith("/"))
                ServicePath = ServicePath.Substring(0, ServicePath.Length - 1);

            string metadata = string.Format("{0}/$metadata", ServicePath);

            webBrowser.Navigate(metadata);

            MetaData = new MetaData(metadata);
            MetaData.ReadCompleted += new EventHandler(MetaData_ReadCompleted);
        }

        #region Toolbar
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDataServiceConfigForm();
        }
        private void tsBtnOpenWeb_Click(object sender, EventArgs e)
        {
            Process.Start("Firefox.exe", FullPath.Replace( " " , "%20" ) );
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FullPath);
        } 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new E4D.About().ShowDialog();
        }
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            ShowIntellisense();
        } 
        #endregion

        private void Shell_Load(object sender, EventArgs e)
        {
            OpenDataServiceConfigForm();
        }

        #region TreeView
        private void TreeViewExpandAll_Click( object sender, EventArgs e )
        {
            EntityTree.SelectedNode.ExpandAll();
            
        }
        private void TreeViewCollapse_Click( object sender, EventArgs e )
        {
            if (EntityTree.SelectedNode != null) 
                EntityTree.SelectedNode.Collapse();
        }

        void ShowMetadataTree_Click( object sender, EventArgs e )
        {
            if ( this.mainSplitContainer.Panel1Collapsed )
            {
                this.mainSplitContainer.Panel1Collapsed = false;
                btnShowMetadataTree.Text = "Hide Metadata Tree";
            }
            else
            {
                this.mainSplitContainer.Panel1Collapsed = true;
                btnShowMetadataTree.Text = "Show Metadata Tree";
            }
        }
        void EntityTree_AfterSelect( object sender, TreeViewEventArgs e )
        {
            if ( NodeSelected != null )
                NodeSelected.BackColor = Color.White;

            e.Node.BackColor = Color.Yellow;
            NodeSelected = e.Node;
            //txbQuery.Text += e.Node.Text;
        }
        #endregion

        
    }
}
