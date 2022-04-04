using lesson_11.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
            AircraftRepository aircraftRepository = new AircraftRepository();
            CompanyRepository companyRepository = new CompanyRepository();
            CountryRepository countryRepository = new CountryRepository();

            List<string> esCountriesList = countryRepository.RetrieveEuropeanUnionCountries();

            for (int i = 0; i < esCountriesList.Count; i++)
            {
                Console.WriteLine(esCountriesList[i]);
            }

            List<int> esCountriesAircraftsIds = aircraftRepository.RetrieveAircraftsFromEsCountries();

            // to be continued..
        }
    }
}
