using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResxFileFromExcel
{
    public static class InputValidations
    {
        private static bool isCorrectInputFilePathGiven = false;
        private static bool isCorrectOutputFolderPathGiven = false;

        public static bool IsInputExcelFilePathValid()
        {
            isCorrectInputFilePathGiven = false;

            return isCorrectInputFilePathGiven;
        }


        public static bool IsOutputFolderPathValid()
        {
            isCorrectOutputFolderPathGiven = false;

            return isCorrectOutputFolderPathGiven;
        }



    }
}
