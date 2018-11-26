using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace ResxFileFromExcel
{
    public static class ResxGenerator
    {
        public static void Generate(string inputFilePath, string outputDirectory)
        {

            foreach (string key in SupportedLangues.localizationFileNames.Keys)
            {
                string fileName = SupportedLangues.localizationFileNames[key].FileName;
                using (ResXResourceWriter generator = new ResXResourceWriter($"{outputDirectory}\\{fileName}.resx"))
                {
                    generator.AddResource("HeaderString3", "Year");
                }
            }
        }
    }
}
