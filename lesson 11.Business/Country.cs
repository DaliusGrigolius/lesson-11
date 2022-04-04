using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11.Business
{
    public class Country
    {
        public int CountryID { get; }
        public string CountryName { get; }

        public Country(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
    }
}
