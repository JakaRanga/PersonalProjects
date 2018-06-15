using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ExcelFilter
{
    class CsvParser
    {
        private List<string> selectedLines;
        private string title;
        public string strFilters;
        public string fTitle;
        private string[] fTmp;
        private string tempPath = ConfigurationManager.AppSettings["tempPath"].ToString();

        #region OPEN
        public bool openAndRead(string[] filters, string path)
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                selectedLines = new List<string>();
                fTmp = filters;
                string line;
                int i = 0;

                //read the file line by line
                while ((line = file.ReadLine()) != null)
                {
                    //first loop correspond to the workbook Header
                    if (i == 0)
                        title = line;
                    foreach (string str in filters)
                    {
                        if (line.IndexOf(str) != -1)
                        {
                            selectedLines.Add(line);
                            break;
                        }
                    }
                    i++;
                }
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region WRITE
        public void writeInFile(string path)
        {
            strFilters = getFilters(fTmp);
            fTitle = getFileTitle(path);

            tempPath += "\\Filtered Sheets (" + fTitle + ")(" + strFilters + ")";
            System.IO.Directory.CreateDirectory(tempPath);
            System.IO.StreamWriter fWriter = new System.IO.StreamWriter(tempPath + "\\" + fTitle + " Filtered.csv");

            fWriter.WriteLine(title);
            foreach (string str in selectedLines)
                fWriter.WriteLine(str);

            fWriter.Close();
        }

        #endregion

        private string getFilters(string[] f)
        {
            string str = "";
            int i = 0;

            //Get filters like (filter1,filter2,filter3,etc...)
            foreach (string s in f)
            {
                if (i != 0)
                    str += ",";
                str += s;
                i++;
            }
            return str;
        }

        private string getFileTitle(string path)
        {
            string[] tmp = path.Split('\\');
            string[] tmp2;
            string ret;
            int i = 0;

            foreach (string str in tmp)
                i++;
            tmp2 = tmp[i - 1].Split('.');
            ret = tmp2[0];
            return ret;
        }
    }
}
