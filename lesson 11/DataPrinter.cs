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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }

        public void PrintReportAboutEuAircrafts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();     
            
            List<AirCraft> euAircraftsList = aircraftRepository.FilterEuAircrafts();

            for (int i = 0; i < euAircraftsList.Count; i++)
            {
                Console.WriteLine($"- TailNumber: {euAircraftsList[i].TailNumber}");
                Console.WriteLine($"- Model Number: {euAircraftsList[i].Model.Number}");
                Console.WriteLine($"- Model Description: {euAircraftsList[i].Model.Description}");
                Console.WriteLine($"- Owner Company Name: {euAircraftsList[i].OwnerCompany.Name}");
                Console.WriteLine($"- Company Country Code: {euAircraftsList[i].OwnerCompany.Country.Code}");
                Console.WriteLine($"- Company Country Name: {euAircraftsList[i].OwnerCompany.Country.Name}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------");
                Console.ResetColor();
            }
        }

        public void PrintReportAboutNotEuAircrafts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts not from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            List<AirCraft> notEuAircraftsList = aircraftRepository.FilterNotEuAircrafts();

            for (int i = 0; i < notEuAircraftsList.Count; i++)
            {
                Console.WriteLine($"- TailNumber: {notEuAircraftsList[i].TailNumber}");
                Console.WriteLine($"- Model Number: {notEuAircraftsList[i].Model.Number}");
                Console.WriteLine($"- Model Description: {notEuAircraftsList[i].Model.Description}");
                Console.WriteLine($"- Owner Company Name: {notEuAircraftsList[i].OwnerCompany.Name}");
                Console.WriteLine($"- Company Country Code: {notEuAircraftsList[i].OwnerCompany.Country.Code}");
                Console.WriteLine($"- Company Country Name: {notEuAircraftsList[i].OwnerCompany.Country.Name}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------");
                Console.ResetColor();
            }
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
