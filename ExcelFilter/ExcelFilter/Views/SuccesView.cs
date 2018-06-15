using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace ExcelFilter
{
    public partial class SuccesView : Form
    {
        private string tempPath = ConfigurationManager.AppSettings["tempPath"].ToString();
        public SuccesView(string fTitle, string strfilters)
        {
            InitializeComponent();
            this.pathLabel.Text = tempPath + "\\Filtered Sheets (" + fTitle + ")(" + strfilters + ")";
            this.pathLabel.Left = (this.Width - pathLabel.Width) / 2;
        }

        #region PROPERTIES
        private void openDirButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(this.pathLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
