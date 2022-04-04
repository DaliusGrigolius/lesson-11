using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class CountryRepository
    {
        private List<Country> countries { get; }
        public List<Country> esCountries { get; }

        public CountryRepository()
        {
            countries = new List<Country>();
            esCountries = new List<Country>();

            countries.Add(new Country("LT", "Lietuva"));
            countries.Add(new Country("EN", "Anglija"));
            countries.Add(new Country("PL", "Lenkija"));

            esCountries.Add(new Country("BG", "Belgija"));
            esCountries.Add(new Country("LT", "Lietuva"));
            esCountries.Add(new Country("IT", "Italija"));
            esCountries.Add(new Country("LV", "Latvija"));
            esCountries.Add(new Country("ES", "Estija"));
            esCountries.Add(new Country("PL", "Lenkija"));
            esCountries.Add(new Country("FN", "Suomija"));

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
            List<string> esCountriesFiltered = new List<string>(); 

            for (int i = 0; i < esCountries.Count; i++)
            {
                for (int j = 0; j < countries.Count; j++)
                {
                    if(esCountries[i].Name == countries[j].Name)
                    {
                        esCountriesFiltered.Add(countries[j].Name);
                    }
                }
            }
            return esCountriesFiltered;
        }
    }
}
