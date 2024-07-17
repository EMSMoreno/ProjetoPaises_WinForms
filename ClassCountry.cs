using ProjetoPaises_WinForms;

namespace ProjetoPaisesC
{
    public class ClassCountry
    {
        public string CommonName { get; set; }
        public string OfficialName { get; set; }
        public Dictionary<string, ClassCountryCurrency> Currencies { get; set; }
        public List<string> Capital { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public long Population { get; set; }
        public ClassCountryGini Gini { get; set; }
        public ClassCountryFlags Flags { get; set; }
        public Dictionary<string, ClassCountryTranslation> Translations { get; set; } = new Dictionary<string, ClassCountryTranslation>();
        public List<string> Timezones { get; set; }
        public string Continent { get; set; }
        public string FlagDescription { get; set; }

        public ClassCountry()
        {
            CommonName = string.Empty;
            Capital = new List<string>();
            Timezones = new List<string>();
        }
    }
}