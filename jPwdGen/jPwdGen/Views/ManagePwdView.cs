using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jPwdGen.EntityF;

namespace jPwdGen
{
    public partial class ManagePwdView : Form
    {
        private List<PwdUser> listPwd;
        public ManagePwdView(List<PwdUser> listTmp)
        {
            string[] tmp = new string[3];

            listPwd = listTmp;
            InitializeComponent();
            initData(listTmp);
        }

        private void initData(List<PwdUser> listPwd)
        {
            string[] tmp = new string[3];

            foreach (PwdUser pwdUser in listPwd)
            {
                if (pwdUser.IS_ACTIVE == 1)
                {
                    tmp[0] = pwdUser.ID.ToString();
                    tmp[1] = pwdUser.LB_SOFT;
                    tmp[2] = pwdUser.LB_PWD;
                    this.listView1.Items.Add(new ListViewItem(tmp));
                }
            }
        }

        #region PROPERTIES

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (MessageBox.Show("Etes-vous sur de vouloir changer les paramètres de ce mot de passe ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (jPwdGenEntities newPwd = new jPwdGenEntities())
                {
                    id = int.Parse(idPwdTextBox.Text);
                    PwdUser pwd = newPwd.PwdUser.FirstOrDefault(r => r.ID == id);
                    pwd.LB_SOFT = selectedSoftTextBox.Text;
                    pwd.LB_PWD = selectedPwdTextBox.Text;

                    newPwd.SaveChanges();
                }
                /*this.listView1.Clear();
                initData(listPwd);*/
            }

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                idPwdTextBox.Text = item.SubItems[0].Text;
                selectedPwdTextBox.Text = item.SubItems[2].Text;
                selectedSoftTextBox.Text = item.SubItems[1].Text;
            }
            else
            {
                idPwdTextBox.Text = "N° Id";
                selectedSoftTextBox.Text = "Nom du logiciel : ";
                selectedPwdTextBox.Text = "Mot de passe associé";
            }
        }

        private void deletePwdButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Etes-vous sûr(e) de vouloir supprimer DEFINITIVEMENT ce mot de passe ?",
                    "Avertissement", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) 
                            == DialogResult.Yes)
            {
                int id = int.Parse(idPwdTextBox.Text);
                using (jPwdGenEntities pwdUserDb = new jPwdGenEntities())
                {
                    PwdUser pwdDeleted = pwdUserDb.PwdUser.FirstOrDefault(r => r.ID == id);
                    pwdDeleted.IS_ACTIVE = 0;
                    pwdUserDb.SaveChanges();
                }
                this.listView1.Clear();
                /*foreach (ListViewItem item in listView1.Items)
                        listView1.Items.Clear();*/
                initData(this.listPwd);
            }
        } 
        #endregion
    }
}

