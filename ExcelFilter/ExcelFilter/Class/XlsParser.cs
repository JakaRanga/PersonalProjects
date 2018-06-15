using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExcelFilter
{
    public class XlsParser
    {

        #region GLOBAL VARIABLES
        private string tempPath = ConfigurationManager.AppSettings["tempPath"].ToString();
        private string[] sheetName;
        private List<string> srcList = new List<string>();
        private List<string> fList = new List<string>();
        private List<string> selectedLines;
        private string title;
        public string fTitle;
        public string strfilters;
        #endregion

        #region EXCEL GLOBAL VARIABLE

        Excel.Application xlApp;

        #endregion

        #region CONVERT

        public void convertXls(string path)
        {
            fTitle = getFileTitle(path);

            //Create and set the current directory "Source sheets"
            System.IO.Directory.CreateDirectory(tempPath + "\\" + "Source Sheets " + fTitle);
            System.IO.Directory.SetCurrentDirectory(tempPath + "\\" + "Source Sheets " + fTitle);

            //Convert Xls File to Csv files
            toCsv(tempPath + "\\" + "Source Sheets", path);

        }

        private void toCsv(string dPath, string xPath)
        {
            int i = 1;
            string src;

            //Launch Excel App
            xlApp = new Excel.Application();
            xlApp.DisplayAlerts = false;
            xlApp.Visible = false;

            //open Workbook
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(xPath);
            xlWorkbook.Activate();
            sheetName = new string[xlWorkbook.Worksheets.Count];

            //Convert to csv (1 sheet => 1 .csv)
            foreach (Excel.Worksheet sheet in xlWorkbook.Worksheets)
            {
                sheet.Select();
                sheetName[i - 1] = sheet.Name;
                src = System.IO.Directory.GetCurrentDirectory() + "\\Sheet_" + i.ToString() + ".csv";
                xlWorkbook.SaveAs(src, Excel.XlFileFormat.xlCSV);
                srcList.Add(src);
                i++;
            }

            //Clean all Interop shits
            foreach (Excel.Worksheet sheet in xlWorkbook.Sheets)
                while (Marshal.ReleaseComObject(sheet) != 0) { }

            xlWorkbook.Close(false);
            xlApp.Quit();

            while (Marshal.ReleaseComObject(xlApp) != 0) { }
            while (Marshal.ReleaseComObject(xlWorkbook) != 0) { }

            xlWorkbook = null;
            xlApp = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.WaitForPendingFinalizers();

        }

        #endregion

        #region FILTER
        public bool putFilterOnDaShit(string[] filters)
        {
            int i = 1;
            strfilters = getFilters(filters);

            //Create the Directory for the Filtered Files
            System.IO.Directory.CreateDirectory(tempPath + "\\Filtered Sheets (" + fTitle + ")(" + strfilters + ")");

            //1 Src File = 1 loop
            foreach (string path in srcList)
            {
                //Read, put filters and write in .csv files
                if (!openAndRead(filters, path))
                    return false;
                writeInFile(i, sheetName[i - 1]);
                i++;

                //Delete tmp csv files
                System.IO.File.Delete(path);
            }
            //Delete Tmp csv directory
            System.IO.Directory.SetCurrentDirectory(@"C:\");
            System.IO.Directory.Delete(tempPath + "\\" + "Source Sheets " + fTitle);

            return true;
        }

        private bool openAndRead(string[] filters, string path)
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                selectedLines = new List<string>();
                string line;
                int i = 0;

                //Read all the lines in the file
                while ((line = file.ReadLine()) != null)
                {
                    line = line.Replace(',', ';');
                    if (i == 0)
                        title = line;
                    foreach (string str in filters)
                    {
                        // Save the line if the line match w/ one filter
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

        private void writeInFile(int nb, string sName)
        {
            System.IO.StreamWriter fWriter = new System.IO.StreamWriter(tempPath + "\\Filtered Sheets (" + fTitle + ")\\" + sName + ".csv");
            fList.Add(tempPath + "\\Filtered Sheets (" + fTitle + ")\\" + sName + ".csv");

            //Write the Excel Header of the source .xls(x) file in the
            //Filtered .csv first line
            fWriter.WriteLine(title);

            //Paste all the selected lines in the new .csv file
            foreach (string str in selectedLines)
                fWriter.WriteLine(str);

            fWriter.Close();
        }

        #endregion

        #region GET FILTERS / TITLE
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

            //Get the real file name of the document
            foreach (string str in tmp)
                i++;
            tmp2 = tmp[i - 1].Split('.');
            ret = tmp2[0];
            return ret;
        }

        #endregion

        #region RECONVERT TO XLS

        public void toXls()
        {
          /*  Excel.Workbook xlWorkbook = this.xlApp.Workbooks.Add();

            foreach (string str in fList)
            {
                Excel.Worksheet xlWorksheet = xlWorkbook.Worksheets.Add();
                xlWorkbook.me
            }*/
        }

        #endregion
    }
}
