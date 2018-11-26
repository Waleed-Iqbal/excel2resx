using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResxFileFromExcel
{
    public struct FileInfo
    {
        public bool IsSelected;
        public string FileName;
    }
    public static class SupportedLangues
    {
        public const string Greek = "el";
        public const string Dutch = "nl";
        public const string German = "de";
        public const string French = "fr";
        public const string English = "en";
        public const string Spanish = "es";
        public const string Swedish = "sv";
        public const string Italian = "it";
        public const string Norwegian = "nb";
        public const string Portuguese = "pt";

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


        public static Dictionary<string, FileInfo> localizationFileNames = new Dictionary<string, FileInfo>() {
            { SupportedLangues.Greek, new FileInfo(){ FileName = $"{SupportedLangues.Greek}-GR", IsSelected=GreekSelected } },
            { SupportedLangues.Dutch,  new FileInfo(){ FileName = $"{SupportedLangues.Dutch}-BE", IsSelected=DutchSelected } },
            { SupportedLangues.German, new FileInfo(){ FileName = $"{SupportedLangues.German}-DE", IsSelected=GermanSelected } },
            { SupportedLangues.French, new FileInfo(){ FileName = $"{SupportedLangues.French}-FR", IsSelected=FrenchSelected } },
            { SupportedLangues.Spanish, new FileInfo(){ FileName = $"{SupportedLangues.Spanish}-ES", IsSelected=SpanishSelected  } },
            { SupportedLangues.Swedish, new FileInfo(){ FileName = $"{SupportedLangues.Swedish}-SV", IsSelected=SwedishSelected} },
            { SupportedLangues.Italian, new FileInfo(){ FileName = $"{SupportedLangues.Italian}-IT", IsSelected=ItalianSelected } },
            { SupportedLangues.English, new FileInfo(){ FileName = $"{SupportedLangues.English}-GB", IsSelected=EnglishSelected } },
            { SupportedLangues.Norwegian, new FileInfo(){ FileName = $"{SupportedLangues.Norwegian}-NB", IsSelected=NorwegianSelected } },
            { SupportedLangues.Portuguese, new FileInfo(){ FileName = $"{SupportedLangues.Portuguese}-PT", IsSelected=PortugueseSelected } }
        };

    }
}
