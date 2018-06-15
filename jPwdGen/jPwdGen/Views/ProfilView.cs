using jPwdGen.EntityF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jPwdGen
{
    public partial class ProfilView : Form
    {
        List<PwdUser> listPwd;
        private int id;
        public ProfilView(Users user)
        {
            InitializeComponent();
            if (user.LB_EMAIL != "jeremy.bouton@epitech.eu")
                this.dataAccessButton.Hide();
            welcomeLabel.Text = "Bienvenue sur votre compte, " + user.LB_FNAME + " !";
            welcomeLabel.Location = new Point(315 - welcomeLabel.Width / 2, 54);
            id = user.ID;
            listPwd = user.PwdUser.ToList();
        }

        private void pwdGenButton_Click(object sender, EventArgs e)
        {
            PwdParamsView pwdParamsView = new PwdParamsView();
            pwdParamsView.ShowDialog();
            PwdGenerator pGen = new PwdGenerator(pwdParamsView, id);
            MessageBox.Show("Votre mot de passe pour " + pwdParamsView.softName + " est :\n" + pGen.pwd, "Succès", MessageBoxButtons.OK);
            MessageBox.Show("Votre mot de passe a été enregistré avec succès!", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void managePwdButton_Click(object sender, EventArgs e)
        {
            ManagePwdView managePwdView = new ManagePwdView(listPwd);
            managePwdView.ShowDialog();
        }

        private void dataAccessButton_Click(object sender, EventArgs e)
        {
           
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage();
            email.From = new System.Net.Mail.MailAddress("j.bouton88@gmail.com");
            email.To.Add(new MailAddress("jean.laurain@epitech.eu"));
            email.IsBodyHtml = true;
            email.Subject = "Test";
            email.Body = "Ce mail a été envoyé par Jaka grace a un programme en C#";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("source", "mot-de-passe");
            try
            {
                smtp.Send(email);
                MessageBox.Show("email est envoyer");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}
