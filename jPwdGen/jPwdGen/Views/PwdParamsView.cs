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
    public partial class PwdParamsView : Form
    {
        public string softName;
        public int pwdLenght = 8;   //
        public bool Maj = true;     // Initilisation des variables
        public bool min = true;     // avec les paramètres par défaut
        public bool nb = true;      // 
        public bool spec = true;    //

        public PwdParamsView()
        {
            InitializeComponent();
        }

        private void softTextBox_Click(object sender, EventArgs e)
        {
            softTextBox.Text = "";
            softTextBox.ForeColor = SystemColors.WindowText;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string msg = "";
            int i = 0;

            if (softTextBox.Text != "ex: YouTube")
                softName = softTextBox.Text;
            else
                softName = "Indéfini";
            pwdLenght = int.Parse(lenghtTextBox.Text);
            if (!majCheckBox.Checked)
            {
                Maj = false;
                i++;
            }
            if (!minCheckBox.Checked)
            {
                min = false;
                i++;
            }
            if (!specCheckBox.Checked)
            {
                spec = false;
                i++;
            }
            if (!nbCheckBox.Checked)
            {
                nb = false;
                i++;
            }
            if (pwdLenght > 20)
                msg = "Votre mot de passe ne peux dépasser 20 caractères.";
            else if (softTextBox.Text == "ex : YouTube")
                msg = "Veuillez spécifié le site ou logiciel lié au mot de passe.";
            else if (i > 1)
                msg = "Coché au moins 3 cases.";
            else if (msg != "")
                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pwdLenght <= 20)
                this.Close();
        }
    }
}
