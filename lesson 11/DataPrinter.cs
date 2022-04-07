using lesson_11.Business;
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
            List<string> listas = countryRepository.FilterEuCountries();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EU Countries list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine($"- {listas[i]}");
            }
            Console.WriteLine("------------------------------------");
        }

        public void PrintFilteredNotEuCountries()
        {
            List<string> listas = countryRepository.FilterNotEuCountries();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Not EU Countries list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine($"- {listas[i]}");
            }
            Console.WriteLine("------------------------------------");
        }

        public void PrintEuAircraftsIds()
        {
            List<AirCraft> filteredEuAircraftsList = aircraftRepository.FilterEuAircrafts();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EU Aircrafts ID's list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < filteredEuAircraftsList.Count; i++)
            {
                Console.WriteLine($"- {filteredEuAircraftsList[i].TailNumber}");
            }
            Console.WriteLine("------------------------------------");
        }

        public void PrintNotEuAircraftsIds()
        {
            List<AirCraft> filteredNotEuAircraftsList = aircraftRepository.FilterNotEuAircrafts();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Not EU Aircrafts ID's list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < filteredNotEuAircraftsList.Count; i++)
            {
                Console.WriteLine($"- {filteredNotEuAircraftsList[i].TailNumber}");
            }
            Console.WriteLine("------------------------------------");
        }

        public void PrintReportAboutEuAircrafts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();     
            
            List<AirCraft> euAircraftsList = aircraftRepository.FilterEuAircrafts();

            euAircraftsList.ForEach(i => Console.Write($"Aircraft TailNumber: {i.TailNumber}\r\nAircraft Model: {i.Model.Number}\r\nAircraft Company: {i.OwnerCompany.Name}\r\nCountry: {i.OwnerCompany.Country.Name}\r\n------------------------------------\r\n"));
        }

        public void PrintReportAboutNotEuAircrafts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts not from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            List<AirCraft> notEuAircraftsList = aircraftRepository.FilterNotEuAircrafts();

            notEuAircraftsList.ForEach(i => Console.Write($"Aircraft TailNumber: {i.TailNumber}\r\nAircraft Model: {i.Model.Number}\r\nAircraft Company: {i.OwnerCompany.Name}\r\nCountry: {i.OwnerCompany.Country.Name}\r\n------------------------------------\r\n"));
        }

        public void PrintAllAircraftsData()
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
