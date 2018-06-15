using jPwdGen.EntityF;
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
    public partial class RegistrationView : Form
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            using (jPwdGenEntities userDb = new jPwdGenEntities())
            {
                if (CheckAllTxtBox())
                {
                    Users user = new Users
                    {
                        LB_FNAME = fnameTextBox.Text,
                        LB_LNAME = lnameTextBox.Text,
                        LB_EMAIL = emailTextBox.Text,
                        LB_PWD = pwdTextBox.Text,
                        LB_USER = lnameTextBox.Text.ToLower() + "," + fnameTextBox.Text.ToLower(),
                        //SUPER_USER = 0
                    };

                    userDb.Users.Add(user);
                    userDb.SaveChanges();
                }
                else
                    return;
            }
            MessageBox.Show("Votre compte a été créé avec succès.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool CheckAllTxtBox()
        {
            string msg = "";
            if (lnameTextBox.Text == null)
                msg = "Vous devez rentrer votre nom.";
            else if (fnameTextBox.Text == null)
                msg = "Vous devez rentrer votre prénom.";
            else if (emailTextBox.Text == null)
                msg = "Vous devez rentrer votre E-Mail.";
            else if (pwdTextBox.Text == null)
                msg = "Vous devez rentrer votre mot de passe.";
            else if (vPwdTextBox.Text == null)
                msg = "Vous devez vérifier votre mot de passe.";
            else if (pwdTextBox.Text != vPwdTextBox.Text)
                msg = "La vérification de votre mot de passe à échoué.";
            if (msg == "")
                return true;
            else
            {
                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
