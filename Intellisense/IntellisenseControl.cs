using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataSrviceViewer
{
    public partial class IntellisenseControl : ListBox
    {
        IntelliSense IntelliSense;
        TextBox      m_TxbQuery;

        public TextBox txbQuery
        {
            get { return m_TxbQuery; }
            set 
            { 
                m_TxbQuery = value;

                if (m_TxbQuery != null)
                {
                    m_TxbQuery.KeyDown     += txbQuery_KeyDown;
                    m_TxbQuery.TextChanged += txbQuery_TextChanged;
                }
            }
        }

        public IntellisenseControl()
        {
            InitializeComponent();
            this.Visible = false;
        }

        public void Start(MetaData meta)
        {
            IntelliSense = new IntelliSense(meta);
        }

        #region Itellisense Methods
        void lbItellisense_Selected(object sender, MouseEventArgs e)
        {
            lbItellisense_Selected(sender, EventArgs.Empty);
        }
        void lbItellisense_Selected(object sender, EventArgs e)
        {
            if (this.SelectedItem == null) return;

            string intellisens = this.SelectedItem.ToString();

            txbQueryMerge_Intellisense(intellisens);

            txbQuery.SelectionStart = txbQuery.Text.Length;
            this.Visible = false;
            toolTip.Hide(this);
        }
        public void UpdateQureyAutoSource(string[] source)
        {
            if (source == null || source.Length == 0) return;

            ItellisenseSuspendEvents();
            this.DataSource = source;
            this.SelectedIndex = -1;
            ItellisenseResumeEvents();
            SetItellisenseLocation();
            this.Visible = true;

        }
        void SetItellisenseLocation()
        {
            Point old = txbQuery.Location;
            this.Location = new Point(110 + txbQuery.Text.Length * 2, old.Y + 30);
        }
        void ItellisenseSuspendEvents()
        {
            this.MouseClick  -= lbItellisense_Selected;
            this.Enter       -= lbItellisense_Selected;
            this.DoubleClick -= lbItellisense_Selected;
        }
        void ItellisenseResumeEvents()
        {
            this.MouseClick  += lbItellisense_Selected;
            this.Enter       += lbItellisense_Selected;
            this.DoubleClick += lbItellisense_Selected;
        }
        void txbQueryMerge_Intellisense(string intellisens)
        {
            string url = txbQuery.Text;

            int strS = url.LastIndexOf('/');
            int strQ = url.LastIndexOf('?');
            int strE = url.LastIndexOf('=');
            int spac = url.LastIndexOf( " " );
            int sep = url.LastIndexOf('&');

            if (sep < strE) 
            {
                sep = strE;
                if (sep < spac)
                {
                    sep = spac;
                    if (url.EndsWith("= ")) sep--;
                }
            }
            if (sep < strQ) sep = strQ;
            if (sep < strS) sep = strS;

            if (intellisens == "?" ||
                intellisens == "/" ||
                intellisens == "&")
                sep = url.Length - 1;


            txbQuery.Text = url.Substring(0, sep + 1) + intellisens;
        }
        void ShowTooTip()
        {
            Point location = new Point( this.Size.Width +5 , 50 );
            string tp = IntelliSense.GetToolTipItem( this.SelectedItem.ToString() ); 
            toolTip.Show( tp , this, location);
        }
        public void ShowIntelliSense()
        {
            txbQuery_TextChanged(this, EventArgs.Empty);
        }
        #endregion

        #region txbQuery
        void txbQuery_TextChanged(object sender, EventArgs e)
        {
            if (IntelliSense != null)
            {
                UpdateQureyAutoSource(IntelliSense.GetIntelliSense(txbQuery.Text));
            }
        }
        void txbQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && this.SelectedIndex < this.Items.Count - 1)
            {
                this.SelectedIndex++;
                ShowTooTip();
                
            }

            if (e.KeyData == Keys.Up && this.SelectedIndex > 0)
            {
                this.SelectedIndex--;
                ShowTooTip();
            }

            if (e.KeyData == Keys.Enter && this.Visible == true)
                lbItellisense_Selected(this, EventArgs.Empty);

        }        
        #endregion
    }
}
