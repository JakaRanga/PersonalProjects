using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jPwdGen.EntityF;

namespace jPwdGen
{
    public partial class ConnectionView : Form
    {
        public ConnectionView()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            using (jPwdGenEntities userDb = new jPwdGenEntities())
            {
                Users user = userDb.Users.FirstOrDefault(r => r.LB_EMAIL == emailTextBox.Text);
                if (user == null)
                    MessageBox.Show("L'e-mail entré est invalide, veuillez réessayer ou créer un compte jPwdGen.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (user.LB_PWD != pwdTextBox.Text)
                    MessageBox.Show("L'e-mail ou le mot de passe entré est invalide, veuillez réessayer ou créer un compte jPwdGen.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Close();
                    ProfilView profilView = new ProfilView(user);
                    profilView.Show();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
