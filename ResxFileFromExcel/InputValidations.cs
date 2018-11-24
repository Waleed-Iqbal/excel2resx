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
        public static bool IsALanguageSelected = false;
        public static bool AreAllLanguagesSelected = false;

        private static bool IsCorrectInputFilePathGiven = false;
        private static bool IsCorrectOutputFolderPathGiven = false;

        public static bool IsInputExcelFilePathValid(string path)
        {
            IsCorrectInputFilePathGiven = File.Exists(path);

            return IsCorrectInputFilePathGiven;
        }


        public static bool IsOutputFolderPathValid(string path)
        {
            IsCorrectOutputFolderPathGiven = Directory.Exists(path);

            return IsCorrectOutputFolderPathGiven;
        }


        public static bool AreInputsValid()
        {
            return IsCorrectInputFilePathGiven && IsCorrectOutputFolderPathGiven;
        }


        public static bool IsExcelSheetInRightFormat(string path)
        {
            bool isFileInValidFormat = false;

            return isFileInValidFormat;
        }

    }
}
