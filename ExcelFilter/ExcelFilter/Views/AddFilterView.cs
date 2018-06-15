using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelFilter
{
    public partial class AddFilterView : Form
    {
        private ComboBox.ObjectCollection newFilterItems;
        private ComboBox.ObjectCollection tmpFilterItems;
        public bool isOk = false;
        private int newNbFilter;
        public string[] fstr;

        public AddFilterView(ComboBox.ObjectCollection oldFilterItems, int nbFilters)
        {
            InitializeComponent();
            newNbFilter = nbFilters;
            newFilterItems = oldFilterItems;
            tmpFilterItems = oldFilterItems;
            initDatas(newFilterItems, nbFilters);
        }

        private void initDatas(ComboBox.ObjectCollection filters, int nb)
        {
            //filter combobox
            int i = -1;
            while (i++ != nb - 1)
                this.newFComboBox.Items.Add(filters[i]);
        }

        #region PROPERTIES

        private void addFilter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.newFComboBox.Text) || !String.IsNullOrWhiteSpace(this.newFComboBox.Text))
            {
                if (!this.newFComboBox.Text.Contains(' '))
                {
                    this.newFilterItems.Add(this.newFComboBox.Text);
                    newNbFilter++;
                    this.newFComboBox.Items.Clear();
                    initDatas(this.newFilterItems, this.newNbFilter);
                }
            }
            this.newFComboBox.SelectedIndex = 0;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.newFComboBox.Text) || !String.IsNullOrWhiteSpace(this.newFComboBox.Text))
            {
                this.newFilterItems.Remove(this.newFComboBox.SelectedItem);
                this.newFComboBox.Items.Clear();
                this.newNbFilter--;
                if (this.newNbFilter != 0)
                    initDatas(this.newFilterItems, this.newNbFilter);
            }
            if (this.newNbFilter != 0)
                this.newFComboBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (newNbFilter == 0)
            {
                isOk = false;
                MessageBox.Show("Aucun filtre n'est renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Les nouveaux filtres vont être sauvegardés", "Avertissement",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                == DialogResult.OK)
            {
                isOk = true;
                fstr = new string[newNbFilter];
                int tmp = 0;

                foreach (string str in fstr)
                {
                    this.newFComboBox.SelectedIndex = tmp;
                    fstr[tmp] = this.newFComboBox.SelectedItem.ToString();
                    tmp++;
                }

                this.Close();
            }

        }
        private void abortButton_Click(object sender, EventArgs e)
        {
            isOk = false;
            this.Close();
        }

        #endregion
    }
}
