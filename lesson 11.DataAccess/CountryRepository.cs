using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class CountryRepository
    {
        private List<Country> countries { get; }
        private List<Country> euCountries { get; }
        private List<string> euCountriesFiltered { get; }
        private List<string> notEuCountriesFiltered { get; }

        public CountryRepository()
        {
            countries = new List<Country>();
            euCountries = new List<Country>();
            euCountriesFiltered = new List<string>();
            notEuCountriesFiltered = new List<string>();

            countries.Add(new Country("LT", "Lithuania", true));
            countries.Add(new Country("GB", "Great Britain", false));
            countries.Add(new Country("PL", "Poland", true));

            euCountries.Add(new Country("BG", "Belgium", true));
            euCountries.Add(new Country("LT", "Lithuania", true));
            euCountries.Add(new Country("IT", "Italy", true));
            euCountries.Add(new Country("LV", "Latvia", true));
            euCountries.Add(new Country("ES", "Estonia", true));
            euCountries.Add(new Country("PL", "Poland", true));
            euCountries.Add(new Country("FN", "Finland", true));
        }

        public List<Country> Retrieve()
        {
            return countries;
        }

        public Country Retrieve(int number)
        {
            return countries[number];
        }

        public List<string> FilterEuCountries()
        {
            if (euCountriesFiltered.Count > 0) euCountriesFiltered.Clear();

            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].RegistrationCountry)
                {
                    euCountriesFiltered.Add(countries[i].Name);
                }
            }     
            return euCountriesFiltered;
        }

        public List<string> FilterNotEuCountries()
        {
            if (notEuCountriesFiltered.Count > 0) notEuCountriesFiltered.Clear();

            for (int i = 0; i < countries.Count; i++)
            {
                if (!countries[i].RegistrationCountry)
                {
                    notEuCountriesFiltered.Add(countries[i].Name);
                }
            }
            return notEuCountriesFiltered;
        }
    }
}
