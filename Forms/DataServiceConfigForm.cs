using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataServicesViewer
{
    public partial class DataServiceConfigForm : Form
    {
        public DataServiceConfigForm()
        {
            InitializeComponent();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }               

        public string ServicePath 
        {
            get { return txbServicePath.Text; }
        }
    }
}
