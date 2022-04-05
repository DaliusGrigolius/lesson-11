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
            ReportItem reportItem = new ReportItem();           

            countryRepository.RetrieveEuropeanUnionCountries();
            countryRepository.PrintFilteredEuCountries();
            aircraftRepository.RetrieveAircraftsFromEuCountries();
            aircraftRepository.PrintEuAircraftsIds();

            reportItem.GenerateReportAboutEuAircrafts();

            Console.ReadLine();
        }
    }
}
