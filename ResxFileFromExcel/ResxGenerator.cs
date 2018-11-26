using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ResxFileFromExcel
{
    public partial class resxGenerator : Form
    {
        delegate void UIEnableDisbale(bool enable);
        delegate void CrossThreadLogger(string log);

        public async void GenerateResx(string inputFilePath, string outputDirectory)
        {
            ClearLog();

            try
            {
                await Task.Run(() =>
                {
                    CrossThreadLogger logger = new CrossThreadLogger(Log);
                    UIEnableDisbale UIControlsEnabler = new UIEnableDisbale(EnableAllUIControls);
                    Invoke(UIControlsEnabler, new object[] { false });

                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(inputFilePath);
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

                    Invoke(logger, new object[] { $"{Constants.STARTED}{Environment.NewLine}" });


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
                            Invoke(logger, new object[] { $"{Constants.ERROR.ToUpper()}: {selectedLanguage} {Constants.TRANSLATION_NOT_AVAILABLE_IN_EXCEL_SHEET}.{Environment.NewLine}" });
                        }
                    }

                    for (int col = 2; col <= totalLanguages; col++)
                    {
                        string language = xlRange.Cells[1, col].Value2.ToString();
                        if (languagesToSkip.Contains(language))
                            continue;

                        using (ResXResourceWriter generator = new ResXResourceWriter($"{outputDirectory}\\{SupportedLangues.LocalizationFilesInfo[language].FileName}.{Constants.RESOURCE_FILE_EXTENSION}"))
                        {
                            Invoke(logger, new object[] { $"{Constants.GENERATING} {language}.{Constants.RESOURCE_FILE_EXTENSION}" });

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

                    Invoke(logger, new object[] { $"{Environment.NewLine}{Constants.FINISHED}" });
                    Invoke(UIControlsEnabler, new object[] { true });
                });
            }
            catch (Exception e)
            {
                tb_generationLog.Text += Environment.NewLine + e.Message;
                EnableAllUIControls(true);
            }
        }
    }
}
