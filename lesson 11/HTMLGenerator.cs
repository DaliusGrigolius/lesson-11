using lesson_11.Business;
using lesson_11.DataAccess;
using System.Collections.Generic;
using System.IO;

namespace lesson_11
{
    public class HTMLGenerator
    {
        public AircraftRepository aircraftRepository { get; }
        public AircraftsData aircraftsData { get; }

        public HTMLGenerator()
        {
            aircraftRepository = new AircraftRepository();
            aircraftsData = new AircraftsData();
        }

        public void GenerateHTMLWithColor() // 5
        {
            List<AirCraft> aircraftsList = aircraftRepository.Retrieve();
            List<string> aircraftsListInStringFormat = aircraftsData.RetrieveAircraftsDataInStringFormat(aircraftsList);

            string fileName = "aircrafts_country_registration_report.html";
            string path = @$"C:\Users\User\Desktop\repos\lesson 11\{fileName}";
            File.WriteAllLines(path, aircraftsListInStringFormat);
        }
    }
}
