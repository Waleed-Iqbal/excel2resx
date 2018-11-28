﻿using System.Collections.Generic;

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
        public const string Greek = Constants.RESOURCE_FILE_PREFIX + Constants.GREEK_SHORT_LOWER + "-" + Constants.GREEK_SHORT_UPPER;
        public const string Dutch = Constants.RESOURCE_FILE_PREFIX + Constants.DUTCH_SHORT_LOWER + "-" + Constants.DUTCH_SHORT_UPPER;
        public const string German = Constants.RESOURCE_FILE_PREFIX + Constants.GERMAN_SHORT_LOWER + "-" + Constants.GERMAN_SHORT_UPPER;
        public const string French = Constants.RESOURCE_FILE_PREFIX + Constants.FRENCH_SHORT_LOWER + "-" + Constants.FRENCH_SHORT_UPPER;
        public const string English = Constants.RESOURCE_FILE_PREFIX + Constants.ENGLISH_SHORT_LOWER + "-" + Constants.ENGLISH_SHORT_UPPER;
        public const string Spanish = Constants.RESOURCE_FILE_PREFIX + Constants.SPANISH_SHORT_LOWER + "-" + Constants.SPANISH_SHORT_UPPER;
        public const string Swedish = Constants.RESOURCE_FILE_PREFIX + Constants.SWEDISH_SHORT_LOWER + "-" + Constants.SWEDISH_SHORT_UPPER;
        public const string Italian = Constants.RESOURCE_FILE_PREFIX + Constants.ITALIAN_SHORT_LOWER + "-" + Constants.ITALIAN_SHORT_UPPER;
        public const string Norwegian = Constants.RESOURCE_FILE_PREFIX + Constants.NORWEGIAN_SHORT_LOWER + "-" + Constants.NORWEGIAN_SHORT_UPPER;
        public const string Portuguese = Constants.RESOURCE_FILE_PREFIX + Constants.PORTUGUESE_SHORT_LOWER + "-" + Constants.PORTUGUESE_SHORT_UPPER;
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
