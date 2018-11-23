using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResxFileFromExcel
{
    public static class InputValidations
    {
        private static bool isCorrectInputFilePathGiven = false;
        private static bool isCorrectOutputFolderPathGiven = false;

        public static bool IsInputExcelFilePathValid(string path)
        {
            isCorrectInputFilePathGiven = File.Exists(path);

            return isCorrectInputFilePathGiven;
        }


        public static bool IsOutputFolderPathValid(string path)
        {
            isCorrectOutputFolderPathGiven = Directory.Exists(path);

            return isCorrectOutputFolderPathGiven;
        }


        public static bool AreInputsValid()
        {
            return isCorrectInputFilePathGiven && isCorrectOutputFolderPathGiven;
        }


        public static bool IsExcelSheetInRightFormat(string path)
        {
            bool isFileInValidFormat = false;

            return isFileInValidFormat;
        }

    }
}
