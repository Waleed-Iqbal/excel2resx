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
                    int totalLanguages = SupportedLangues.LocalizationFilesInfo.Count;

                    for (int row = 1; ; row++)
                    {
                        if (xlRange.Cells[row, 1] != null && xlRange.Cells[row, 1].Value2 != null)
                            localizationKeys.Add(xlRange.Cells[row, 1].Value2.ToString());
                        else
                            break;
                    }

                    UpdateSupportedLanguagesSelection();
                    foreach (string key in SupportedLangues.LocalizationFilesInfo.Keys)
                        if (!SupportedLangues.LocalizationFilesInfo[key].IsSelected)
                            languagesToSkip.Add(key);


                    Invoke(logger, new object[] { $"Started{Environment.NewLine}" });

                    for (int col = 2; col <= totalLanguages; col++)
                    {
                        string language = xlRange.Cells[1, col].Value2.ToString();
                        if (languagesToSkip.Contains(language))
                            continue;

                        using (ResXResourceWriter generator = new ResXResourceWriter($"{outputDirectory}\\{SupportedLangues.LocalizationFilesInfo[language].FileName}.resx"))
                        {
                            Invoke(logger, new object[] { $"Generating {language}.resx" });

                            // reading from languages since first column consist of keys
                            for (int row = 1; ; row++)
                            {
                                if (row > localizationKeys.Count || (xlRange.Cells[row, col] == null && xlRange.Cells[row, col].Value2 == null))
                                    break;

                                generator.AddResource(xlRange.Cells[row, 1].Value2.ToString(), xlRange.Cells[row, col].Value2.ToString());
                            }

                        }
                    }
                    Invoke(logger, new object[] { $"{Environment.NewLine}Finished" });
                    Invoke(UIControlsEnabler, new object[] { true });
                });
            }
            catch (Exception e)
            {
                generationLog.Text += Environment.NewLine + e.Message;
            }
        }
    }
}
