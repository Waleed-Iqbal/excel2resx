using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ResxFileFromExcel
{
    public partial class resxGenerator : Form
    {
        private enum CrossThreadActions
        {
            Logging,
            EnableDisableControls,
            ClearLog
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CrossThreadActions action = (CrossThreadActions)e.ProgressPercentage;
            switch (action)
            {
                case CrossThreadActions.Logging:
                    Log(e.UserState.ToString());
                    break;
                case CrossThreadActions.EnableDisableControls:
                    EnableAllUIControls((bool)e.UserState);
                    break;
                case CrossThreadActions.ClearLog:
                    ClearLog();
                    break;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> languagesToSkip = new List<string>();
            List<string> localizationKeys = new List<string>();
            List<string> languageFilesGenerated = new List<string>();
            List<string> languagesSelectedFromUI = new List<string>();
            List<string> languagesAvailableInExcelSheet = new List<string>();
            List<string> allLanguages = SupportedLangues.LocalizationFilesInfo.Keys.ToList();

            int totalLanguages = SupportedLangues.LocalizationFilesInfo.Count;

            int totalKeys = 0;
            int totalLanguagesInExcelSheet = 0;
            int languagesStartingColumnInExcelSheet = 2;
            int localizationKeysColumnIndexInExcelSheet = 1;
            int rowNumberContainingTheColumnHeadersInExcelSheet = 1;
            int languagesEndingColumnIndex = languagesStartingColumnInExcelSheet + totalLanguages;

            Excel.Range xlRange = null;
            Excel.Application xlApp = null;
            Excel.Workbook xlWorkbook = null;
            Excel.Worksheet xlWorksheet = null;

            var backgroundWorker = (BackgroundWorker)sender;
            try
            {
                backgroundWorker.ReportProgress((int)CrossThreadActions.ClearLog, false);

                // the following order matters
                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(tb_input_excel_path.Text);
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;

                backgroundWorker.ReportProgress((int)CrossThreadActions.EnableDisableControls, false);
                backgroundWorker.ReportProgress((int)CrossThreadActions.Logging, $"{Constants.STARTED}{Environment.NewLine}");

                for (int col = languagesStartingColumnInExcelSheet; ; col++)
                {
                    if (xlRange.Cells[rowNumberContainingTheColumnHeadersInExcelSheet, col] == null ||
                        xlRange.Cells[rowNumberContainingTheColumnHeadersInExcelSheet, col].Value2 == null ||
                        xlRange.Cells[rowNumberContainingTheColumnHeadersInExcelSheet, col].Value2.ToString() == "")
                        break; // reached end of excel sheet's available columns

                    languagesAvailableInExcelSheet.Add(xlRange.Cells[rowNumberContainingTheColumnHeadersInExcelSheet, col].Value2.ToString());
                }
                totalLanguagesInExcelSheet = languagesAvailableInExcelSheet.Count;


                for (int row = 1; ; row++)
                {
                    if (xlRange.Cells[row, localizationKeysColumnIndexInExcelSheet] != null &&
                        xlRange.Cells[row, localizationKeysColumnIndexInExcelSheet].Value2 != null)
                            localizationKeys.Add(xlRange.Cells[row, localizationKeysColumnIndexInExcelSheet].Value2.ToString());
                    else
                        break;
                }
                totalKeys = localizationKeys.Count;

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
                        backgroundWorker.ReportProgress((int)CrossThreadActions.Logging, $"{Constants.ERROR.ToUpper()}: {selectedLanguage} {Constants.TRANSLATION_NOT_AVAILABLE_IN_EXCEL_SHEET}.{Environment.NewLine}");
                    }
                }

                for (int col = languagesStartingColumnInExcelSheet; col < languagesEndingColumnIndex; col++)
                {
                    string language = xlRange.Cells[rowNumberContainingTheColumnHeadersInExcelSheet, col].Value2.ToString();
                    if (languagesToSkip.Contains(language))
                        continue;

                    using (ResXResourceWriter generator = new ResXResourceWriter($"{tb_output_resx_path.Text}\\{SupportedLangues.LocalizationFilesInfo[language].FileName}.{Constants.RESOURCE_FILE_EXTENSION}"))
                    {
                        backgroundWorker.ReportProgress((int)CrossThreadActions.Logging, $"{Constants.GENERATING} {language}.{Constants.RESOURCE_FILE_EXTENSION}");
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
            }
            catch (Exception ex)
            {
                backgroundWorker.ReportProgress((int)CrossThreadActions.Logging, $"{Environment.NewLine} {ex.Message}.{Environment.NewLine}");
                EnableAllUIControls(true);
            }
            finally
            {
                Marshal.FinalReleaseComObject(xlRange);
                Marshal.FinalReleaseComObject(xlWorksheet);

                xlWorkbook.Close(Type.Missing, Type.Missing, Type.Missing);
                Marshal.FinalReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.FinalReleaseComObject(xlApp);

                backgroundWorker.ReportProgress((int)CrossThreadActions.Logging, $"{Environment.NewLine} {Constants.FINISHED}");
                backgroundWorker.ReportProgress((int)CrossThreadActions.EnableDisableControls, true);
            }
        }
    }
}
