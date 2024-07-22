using ProjetoPaises_WinForms;
using System;
using System.Collections.Generic;

namespace ProjetoPaisesC
{
    public class ClassCountry
    {
        public ClassCountryName Name { get; set; }
        public Dictionary<string, ClassCountryCurrency> Currencies { get; set; }
        public List<string> Capital { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public long Population { get; set; }
        public ClassCountryGini Gini { get; set; }
        public ClassCountryFlags Flags { get; set; }
        public Dictionary<string, ClassCountryTranslation> Translations { get; set; }
        public List<string> Timezones { get; set; }
        public string Continent { get; set; }
        public string FlagDescription { get; set; }

        public ClassCountry()
        {
            Name = new ClassCountryName();
            Currencies = new Dictionary<string, ClassCountryCurrency>();
            Capital = new List<string>();
            Region = string.Empty;
            Subregion = string.Empty;
            Population = 0;
            Gini = new ClassCountryGini();
            Flags = new ClassCountryFlags();
            Translations = new Dictionary<string, ClassCountryTranslation>();
            Timezones = new List<string>();
            Continent = string.Empty;
            FlagDescription = string.Empty;
        }

        public class ClassCountryName : ProjetoPaises_WinForms.ClassCountryName
        {
            public string Common { get; set; }
            public string Official { get; set; }
        }
    }
}
