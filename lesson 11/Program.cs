using lesson_11.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            AircraftRepository aircraftRepository = new AircraftRepository();
            CountryRepository countryRepository = new CountryRepository();
            ReportItem ataskaita = new ReportItem();           

            countryRepository.RetrieveEuropeanUnionCountries();
            countryRepository.PrintFilteredEuCountries();
            aircraftRepository.RetrieveAircraftsFromEuCountries();
            aircraftRepository.PrintEuAircraftsIds();

            ataskaita.RetrieveReport();

            Console.ReadLine();
        }
    }
}
