using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class CountryRepository
    {
        private List<Country> countries { get; }
        public List<Country> euCountries { get; }
        public List<string> euCountriesFiltered { get; }

        public CountryRepository()
        {
            countries = new List<Country>();
            euCountries = new List<Country>();
            euCountriesFiltered = new List<string>();

            countries.Add(new Country("LT", "Lithuania"));
            countries.Add(new Country("GB", "Great Britain"));
            countries.Add(new Country("PL", "Poland"));

            euCountries.Add(new Country("BG", "Belgium"));
            euCountries.Add(new Country("LT", "Lithuania"));
            euCountries.Add(new Country("IT", "Italy"));
            euCountries.Add(new Country("LV", "Latvia"));
            euCountries.Add(new Country("ES", "Estonia"));
            euCountries.Add(new Country("PL", "Poland"));
            euCountries.Add(new Country("FN", "Finland"));
        }

        public List<Country> Retrieve()
        {
            return countries;
        }

        public Country Retrieve(int number)
        {
            return countries[number];
        }

        public List<string> RetrieveEuropeanUnionCountries()
        {
            for (int i = 0; i < euCountries.Count; i++)
            {
                for (int j = 0; j < countries.Count; j++)
                {
                    if(euCountries[i].Name == countries[j].Name)
                    {
                        euCountriesFiltered.Add(countries[j].Name);
                    }
                }
            }
            return euCountriesFiltered;
        }        
    }
}
