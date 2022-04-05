using lesson_11.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_11
{
    public class ReportItem
    {
        public AircraftRepository aircraftRepository { get; }
        //public List<ReportItem> reportItems { get; }

        public ReportItem()
        {
            aircraftRepository = new AircraftRepository();
            //reportItems = new List<ReportItem>();
        }

        public void GenerateReportAboutEuAircrafts()
        {
            List<int> euAircraftsIdsList = aircraftRepository.RetrieveAircraftsFromEuCountries();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aircrafts from EU report:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < euAircraftsIdsList.Count; i++)
            {
                Console.WriteLine($"TailNumber: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).TailNumber}");
                Console.WriteLine($"Model Number: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).Model.Number}");
                Console.WriteLine($"Model Description: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).Model.Description}");
                Console.WriteLine($"Owner Company Name: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Name}");
                Console.WriteLine($"Company Country Code: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Country.Code}");
                Console.WriteLine($"Company Country Name: {aircraftRepository.Retrieve(euAircraftsIdsList[i] - 1).OwnerCompany.Country.Name}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------");
                Console.ResetColor();
            }
        }
    }
}