﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.ComponentModel;

namespace ResxFileFromExcel
{
    public partial class resxGenerator : Form
    {

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:
                    Log(e.UserState.ToString());
                    break;
                case 1:
                    EnableAllUIControls((bool)e.UserState);
                    break;
                case 2:
                    ClearLog();
                    break;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = (BackgroundWorker)sender;

            backgroundWorker.ReportProgress(2, false);

            try
            {
                backgroundWorker.ReportProgress(1, false);

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(tb_input_excel_path.Text);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                List<string> languagesToSkip = new List<string>();
                List<string> localizationKeys = new List<string>();
                List<string> allLanguages = SupportedLangues.LocalizationFilesInfo.Keys.ToList();
                List<string> languagesAvailableInExcelSheet = new List<string>();
                List<string> languagesSelectedFromUI = new List<string>();
                List<string> languageFilesGenerated = new List<string>();

                int totalLanguages = SupportedLangues.LocalizationFilesInfo.Count;
                int totalKeys = 0;
                int totalLanguagesInExcelSheet = 0;

                backgroundWorker.ReportProgress(0, $"{Constants.STARTED}{Environment.NewLine}");

                for (int col = 2; ; col++)
                {
                    if (xlRange.Cells[1, col] == null || xlRange.Cells[1, col].Value2 == null || xlRange.Cells[1, col].Value2.ToString() == "")
                        break; // reached end of excel sheet's available columns

                    languagesAvailableInExcelSheet.Add(xlRange.Cells[1, col].Value2.ToString());
                }
                totalLanguagesInExcelSheet = languagesAvailableInExcelSheet.Count;


                for (int row = 1; ; row++)
                {
                    if (xlRange.Cells[row, 1] != null && xlRange.Cells[row, 1].Value2 != null)
                        localizationKeys.Add(xlRange.Cells[row, 1].Value2.ToString());
                    else
                        break;
                }
                totalKeys = localizationKeys.Count;


                // Excel to 2D array (TEST IF THIS IS FASTER THAN ACCESSING EXCEL EVERY TIME GENERATING A resx FILE)
                //string[,] excelDataArray = new string[totalKeys + 1, totalLanguagesInExcelSheet + 1];
                //for (int row = 1; row <= totalKeys; row++)
                //{
                //    for (int col = 1; col <= totalLanguagesInExcelSheet; col++)
                //    {
                //        excelDataArray[row - 1, col - 1] = xlRange.Cells[row, col].Value2.ToString();
                //    }
                //}

                UpdateSupportedLanguagesSelection();
                foreach (string key in SupportedLangues.LocalizationFilesInfo.Keys)
                {
                    if (!SupportedLangues.LocalizationFilesInfo[key].IsSelected)
                        languagesToSkip.Add(key);
                    else
                        languagesSelectedFromUI.Add(key);
                }


                //Checking if the selected language in UI is available in the excel sheet
                foreach (string selectedLanguage in languagesSelectedFromUI)
                {
                    if (!languagesAvailableInExcelSheet.Contains(selectedLanguage))
                    {
                        backgroundWorker.ReportProgress(0, $"{Constants.ERROR.ToUpper()}: {selectedLanguage} {Constants.TRANSLATION_NOT_AVAILABLE_IN_EXCEL_SHEET}.{Environment.NewLine}");
                    }
                }

                for (int col = 2; col <= totalLanguages; col++)
                {
                    string language = xlRange.Cells[1, col].Value2.ToString();
                    if (languagesToSkip.Contains(language))
                        continue;

                    using (ResXResourceWriter generator = new ResXResourceWriter($"{tb_output_resx_path.Text}\\{SupportedLangues.LocalizationFilesInfo[language].FileName}.{Constants.RESOURCE_FILE_EXTENSION}"))
                    {
                        backgroundWorker.ReportProgress(0, $"{Constants.GENERATING} {language}.{Constants.RESOURCE_FILE_EXTENSION}");
                        // reading from languages since first column consist of keys
                        for (int row = 1; ; row++)
                        {
                            var cell = xlRange.Cells[row, col];
                            if (row > totalKeys || (cell == null && cell.Value2 == null))
                                break;

                            generator.AddResource(xlRange.Cells[row, 1].Value2.ToString(), cell.Value2.ToString());
                        }
                        languageFilesGenerated.Add(language);
                    }
                }

                backgroundWorker.ReportProgress(0, $"{Environment.NewLine}{Constants.FINISHED}");
                backgroundWorker.ReportProgress(1, true);
            }
            catch (Exception ex)
            {
                tb_generationLog.Text += Environment.NewLine + ex.Message;
                EnableAllUIControls(true);
            }

        }

    }
}
