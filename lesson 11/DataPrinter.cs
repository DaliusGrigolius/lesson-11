using lesson_11.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_11
{
    public class DataPrinter
    {
        public AircraftRepository aircraftRepository { get; }
        public CountryRepository countryRepository { get; }
        public AircraftsData aircraftsData { get; }

        public DataPrinter()
        {
            aircraftRepository = new AircraftRepository();
            countryRepository = new CountryRepository();
            aircraftsData = new AircraftsData();
        }

        public void PrintFilteredEuCountries()
        {
            List<string> listas = countryRepository.RetrieveEuropeanUnionCountries();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EU Countries list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine($"- {listas[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }

        public void PrintEuAircraftsIds()
        {
            List<int> listas = aircraftRepository.RetrieveAircraftsFromEuCountries();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EU Aircrafts ID's list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine($"- {listas[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }

        public void PrintReportAboutEuAircrafts()
        {
            List<int> euAircraftsIdsList = aircraftRepository.filteredEuCountriesAircraftsIds;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < euAircraftsIdsList.Count; i++)
            {
                Console.WriteLine($"- TailNumber: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).TailNumber}");
                Console.WriteLine($"- Model Number: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).Model.Number}");
                Console.WriteLine($"- Model Description: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).Model.Description}");
                Console.WriteLine($"- Owner Company Name: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Name}");
                Console.WriteLine($"- Company Country Code: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Country.Code}");
                Console.WriteLine($"- Company Country Name: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Country.Name}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------");
                Console.ResetColor();
            }
        }

        public void PrintAircraftsData()
        {
            List<string> aircraftsDataList = aircraftsData.RetrieveAircraftsDataInStringFormat(aircraftRepository.Retrieve());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Aircrafts list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < aircraftsDataList.Count; i++)
            {
                Console.WriteLine(aircraftsDataList[i]);
            }
        }


    }
}
