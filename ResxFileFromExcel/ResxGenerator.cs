using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Excel = Microsoft.Office.Interop.Excel;

namespace ResxFileFromExcel
{
    public static class ResxGenerator
    {
        public static void Generate(string inputFilePath, string outputDirectory)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(inputFilePath);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            List<string> languagesToSkip = new List<string>();
            List<string> localizationKeys = new List<string>();

            for (int row = 1; ; row++)
            {
                if (xlRange.Cells[row, 1] != null && xlRange.Cells[row, 1].Value2 != null)
                    localizationKeys.Add(xlRange.Cells[row, 1].Value2.ToString());
                else
                    break;
            }



            //foreach (string key in SupportedLangues.localizationFilesInfo.Keys)
            //    if (!SupportedLangues.localizationFilesInfo[key].IsSelected)
            //        languagesToSkip.Add(key);               



            // Reading from excel sheet
            for (int col = 2; ; col++)
            {
                string language = xlRange.Cells[1, col].Value2.ToString();
                // if (languagesToSkip.Contains(language)) continue;

                using (ResXResourceWriter generator = new ResXResourceWriter($"{outputDirectory}\\{SupportedLangues.localizationFilesInfo[language].FileName}.resx"))
                {
                    // reading from languages since first column consist of keys
                    for (int row = 1; ; row++)
                    {
                        if (row > localizationKeys.Count || (xlRange.Cells[row, col] == null && xlRange.Cells[row, col].Value2 == null))
                            break;

                        generator.AddResource(xlRange.Cells[row, 1].Value2.ToString(), xlRange.Cells[row, col].Value2.ToString());
                    }

                }
            }
        }
    }
}
