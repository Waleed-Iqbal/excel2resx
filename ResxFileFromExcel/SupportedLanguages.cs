using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResxFileFromExcel
{
    public struct LanguageSelectionInfo
    {
        public bool IsSelected;
        public string FileName;
        public string Language;
    }


    public static class OutputFileNames
    {
        public const string Greek = Constants.GREEK_SHORT_LOWER + "-" + Constants.GREEK_SHORT_UPPER;
        public const string Dutch = Constants.DUTCH_SHORT_LOWER + "-" + Constants.DUTCH_SHORT_UPPER;
        public const string German = Constants.GERMAN_SHORT_LOWER + "-" + Constants.GERMAN_SHORT_UPPER;
        public const string French = Constants.FRENCH_SHORT_LOWER + "-" + Constants.FRENCH_SHORT_UPPER;
        public const string English = Constants.ENGLISH_SHORT_LOWER + "-" + Constants.ENGLISH_SHORT_UPPER;
        public const string Spanish = Constants.SPANISH_SHORT_LOWER + "-" + Constants.SPANISH_SHORT_UPPER;
        public const string Swedish = Constants.SWEDISH_SHORT_LOWER + "-" + Constants.SWEDISH_SHORT_UPPER;
        public const string Italian = Constants.ITALIAN_SHORT_LOWER + "-" + Constants.ITALIAN_SHORT_UPPER;
        public const string Norwegian = Constants.NORWEGIAN_SHORT_LOWER + "-" + Constants.NORWEGIAN_SHORT_UPPER;
        public const string Portuguese = Constants.PORTUGUESE_SHORT_LOWER + "-" + Constants.PORTUGUESE_SHORT_UPPER;
    }

    public static class SupportedLangues
    {

        //TODO: use the int logic here ... LOOK IT UP
        public static bool GreekSelected = false;
        public static bool DutchSelected = false;
        public static bool GermanSelected = false;
        public static bool FrenchSelected = false;
        public static bool EnglishSelected = false;
        public static bool SpanishSelected = false;
        public static bool SwedishSelected = false;
        public static bool ItalianSelected = false;
        public static bool NorwegianSelected = false;
        public static bool PortugueseSelected = false;


        public static Dictionary<string, LanguageSelectionInfo> LocalizationFilesInfo = new Dictionary<string, LanguageSelectionInfo>() {
            { Constants.GREEK, new LanguageSelectionInfo(){ FileName = OutputFileNames.Greek, IsSelected=GreekSelected } },
            { Constants.DUTCH,  new LanguageSelectionInfo(){ FileName = OutputFileNames.Dutch, IsSelected=DutchSelected } },
            { Constants.GERMAN, new LanguageSelectionInfo(){ FileName = OutputFileNames.German, IsSelected=GermanSelected } },
            { Constants.FRENCH, new LanguageSelectionInfo(){ FileName = OutputFileNames.French, IsSelected=FrenchSelected} },
            { Constants.SPANISH, new LanguageSelectionInfo(){ FileName = OutputFileNames.Spanish, IsSelected=SpanishSelected } },
            { Constants.SWEDISH, new LanguageSelectionInfo(){ FileName = OutputFileNames.Swedish, IsSelected=SwedishSelected } },
            { Constants.ITALIAN, new LanguageSelectionInfo(){ FileName = OutputFileNames.Italian, IsSelected=ItalianSelected } },
            { Constants.ENGLISH, new LanguageSelectionInfo(){ FileName = OutputFileNames.English, IsSelected=EnglishSelected } },
            { Constants.NORWEGIAN, new LanguageSelectionInfo(){ FileName = OutputFileNames.Norwegian, IsSelected=NorwegianSelected } },
            { Constants.PORTUGUESE, new LanguageSelectionInfo(){ FileName = OutputFileNames.Portuguese, IsSelected=PortugueseSelected} }
        };
    }
}
