using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Diagnostics;

namespace DataServicesViewer
{
    public partial class IntellisenseWPFControl : UserControl
    {
        #region Fields
        IntelliSense IntelliSense;        
        string prefix = string.Empty;
        #endregion  
      
        public string Prefix
        {
            get { return prefix; }
            set
            {
                Debug.WriteLine("IntellisenseWPFControl : " + prefix);
                prefix = value;
                ShowIntelliSense(Prefix);
            }
        }
        public new bool IsVisible { get; set; }
        
        public IntellisenseWPFControl()
        {
            InitializeComponent();
            this.PreviewMouseDoubleClick += lbItellisense_PreviewMouseDoubleClick;
            lbItellisense.KeyDown += lbItellisense_KeyDown;
            lbItellisense.SelectionChanged += SelectionChanged;
        }

        void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTooTip();
        }
        void lbItellisense_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.Key == Key.Enter )
                OnSelectedItellisense(GetSelectedIntelliSense());

            if (e.Key == Key.Escape)
                OnSelectedItellisense(string.Empty);

            //if (e.Key == Key.Down)
            //    SelectedIndexDown();

            //if( e.Key == Key.Up )
            //    SelectedIndexUp();
        }
        
        public void Start( MetaData meta )
        {
            IntelliSense = new IntelliSense(meta);
        }
        public void ShowIntelliSense( string prefix )
        {
            this.prefix = prefix;

            if (IntelliSense != null)
            {
                IntellisenseItem[] results = 
                    IntelliSense.GetIntelliSense(prefix);

                if (results == null || results.Length == 0)
                {
                    lbItellisense.ItemsSource = new IntellisenseItem[1];
                    IsVisible = false;
                }
                else
                {
                    lbItellisense.ItemsSource = results;
                    lbItellisense.SelectedIndex = -1;
                    IsVisible = true;
                }               
            }
        }
        public string GetSelectedIntelliSense()
        {
            string intellisens = string.Empty;
            
            if (lbItellisense.SelectedItem != null)
                intellisens = (lbItellisense.SelectedItem as IntellisenseItem).Text;

            string url = prefix;

            int strS = url.LastIndexOf('/');
            int strQ = url.LastIndexOf('?');
            int strE = url.LastIndexOf('=');
            int spac = url.LastIndexOf(" ");
            int spad = url.LastIndexOf(',');
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
            if (sep < spad) sep = spad;
 
            if (intellisens == "?" ||
                intellisens == "/" ||
                intellisens == "&" ||
                intellisens == "(" ||
                intellisens == ")" ||
                intellisens == "," )
                sep = url.Length - 1;


            prefix = url.Substring(0, sep + 1) + intellisens;

            //this.Visibility = Visibility.Collapsed;
            //toolTip.Hide(this);

            return prefix;
        }

        public void SelectedIndexDown()
        {
            lbItellisense.Focus();
            if (lbItellisense.SelectedIndex < lbItellisense.Items.Count - 1)
            {
                lbItellisense.SelectedIndex++;
                ShowTooTip();
            }
        }
        public void SelectedIndexUp()
        {
            lbItellisense.Focus();
            if (lbItellisense.SelectedIndex > 0)
            {
                lbItellisense.SelectedIndex--;
                ShowTooTip();
            }
        }

        #region Itellisense Helper Methods
        
        void ShowTooTip()
        {
            Point location = new Point( this.Width +5 , 50 );
            IntellisenseItem item = lbItellisense.SelectedItem as IntellisenseItem;
            if (item == null) return;

            //string tp = IntelliSense.GetToolTipItem( item.ToolTip ); 
            //toolTip.Show( tp , this, location);
            OnToolTipChanged(item.ToolTip);
        }
        void OnSelectedItellisense(string intellisens)
        {
            if (SelectedItellisense != null)
            {
                SelectedItellisense( this , new IntellisenseEventArgs( intellisens ) );
            }
        }
        void OnToolTipChanged(string tp)
        {
            if (ToolTipChanged != null)
                ToolTipChanged(this, new IntellisenseEventArgs(tp));
        }
        void lbItellisense_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OnSelectedItellisense(GetSelectedIntelliSense());
        }

        #endregion

        #region Events
        public event EventHandler<IntellisenseEventArgs> SelectedItellisense;
        public event EventHandler<IntellisenseEventArgs> ToolTipChanged;
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

    public class IntellisenseEventArgs :EventArgs
	{
        public IntellisenseEventArgs (string  intellisense ) 
	    {
            this.Intellisense = intellisense;
	    }
		public string Intellisense { get; set; }
	}
}
