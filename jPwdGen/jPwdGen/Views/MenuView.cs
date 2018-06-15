using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jPwdGen
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationView registrationView = new RegistrationView();
            registrationView.ShowDialog();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectionView connectionView = new ConnectionView();
            connectionView.ShowDialog();
            this.SendToBack();
        }
    }
}

