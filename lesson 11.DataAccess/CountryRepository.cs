using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class CountryRepository
    {
        private List<Country> countries { get; }

        public CountryRepository()
        {
            countries = new List<Country>();

            countries.Add(new Country("LT", "Lietuva"));
            countries.Add(new Country("EN", "Anglija"));
            countries.Add(new Country("PL", "Lenkija"));
        }

        public List<Country> Retrieve()
        {
            return countries;
        }

        public Country Retrieve(int number)
        {
            return countries[number];
        }
    }
}
