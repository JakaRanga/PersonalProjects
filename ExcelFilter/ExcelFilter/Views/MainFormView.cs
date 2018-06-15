using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ExcelFilter
{
    public partial class MainFormView : Form
    {
        public MainFormView()
        {
            InitializeComponent();
            initDatas();
        }

        private void initDatas()
        {
            //filterComboBox
            string[] filters = ConfigurationManager.AppSettings["baseFilters"].Split(';');

            foreach (string str in filters)
            {
                this.filterComboBox.Items.Add(str);
            }
            this.filterComboBox.SelectedIndex = 0;
        }

        private string[] getFilters()
        {
            string[] finalFilters = new string[this.filterComboBox.Items.Count];
            int i = -1;

            while (i++ != this.filterComboBox.Items.Count - 1)
                finalFilters[i] = this.filterComboBox.Items[i].ToString();

            return finalFilters;
        }

        #region PROPERTIES

        private void browseButton_Click(object sender, EventArgs e)
        {
            this.openXlsFileDialog.Filter =
                "Fichier Excel (.csv/.xlsx)|*.csv;*.xls;*.xlsx";
            this.openXlsFileDialog.ShowDialog();
            this.xlsPathTextBox.Text = this.openXlsFileDialog.FileName;
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            AddFilterView addFilterView = new AddFilterView(this.filterComboBox.Items, this.filterComboBox.Items.Count);
            addFilterView.ShowDialog();

            this.filterComboBox.Items.Clear();

            if (addFilterView.isOk == true)
            {
                foreach (string str in addFilterView.fstr)
                    this.filterComboBox.Items.Add(str);
            }
            else if (addFilterView.isOk == false)
            {
                string[] filters = ConfigurationManager.AppSettings["baseFilters"].Split(';');

                foreach (string str in filters)
                {
                    this.filterComboBox.Items.Add(str);
                }
                this.filterComboBox.SelectedIndex = 0;
            }
        }
        private void filterStartButton_Click(object sender, EventArgs e)
        {
            if (xlsPathTextBox.Text.Contains(".csv"))
                csvStartFiletering();
            else if (xlsPathTextBox.Text.Contains(".xls"))
                xlsStartFiletering();
            else
                MessageBox.Show("Le fichier n'existe pas ou le fichier n'est pas renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void xlsStartFiletering()
        {
            string[] finalFilters = getFilters();

            XlsParser xlsParser = new XlsParser();
            xlsParser.convertXls(this.xlsPathTextBox.Text);
            if (!xlsParser.putFilterOnDaShit(finalFilters))
                return;

            SuccesView succesView = new SuccesView(xlsParser.fTitle, xlsParser.strfilters);
            succesView.ShowDialog();
            this.Close();
        }

        private void csvStartFiletering()
        {
            string[] finalFilters = getFilters();

            CsvParser csvParser = new CsvParser();
            if (!csvParser.openAndRead(finalFilters, this.xlsPathTextBox.Text))
                return;
            csvParser.writeInFile(this.xlsPathTextBox.Text);

            SuccesView succesView = new SuccesView(csvParser.fTitle, csvParser.strFilters);
            succesView.ShowDialog();
            this.Close();
        }

        #endregion

    }
}
