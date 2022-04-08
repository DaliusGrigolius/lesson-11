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

        public void GenerateHTMLWithColor()
        {
            List<AirCraft> aircraftsList = aircraftRepository.Retrieve();
            List<string> aircraftsListInStringFormat = aircraftsData.RetrieveAircraftsDataInStringFormat(aircraftsList);

            var templatePath = @$"C:\Users\User\Desktop\repos\lesson 11\template.html";
            var reportPath2 = @$"C:\Users\User\Desktop\repos\lesson 11\report.html";

            var text = File.ReadAllText(templatePath);

            text.Replace("{Aircraft}", $"{aircraftsListInStringFormat[0]}");
            text.Replace("{Model}", $"{aircraftsListInStringFormat[1]}");
            text.Replace("{ModelDescription}", $"{aircraftsListInStringFormat[2]}");
            text.Replace("{OwnerCompanyName}", $"{aircraftsListInStringFormat[3]}");
            text.Replace("{CountryCode}", $"{aircraftsListInStringFormat[4]}");
            text.Replace("{CountryName}", $"{aircraftsListInStringFormat[5]}");

            File.WriteAllLines(reportPath2, aircraftsListInStringFormat);
        }
    }
}
// ---cia template'as taip atrodo---
//<br><div>
//{Aircraft}<br>
//{Model}<br>
//{ModelDescription}<br>
//{OwnerCompanyName}<br>
//{CountryCode}<br>
//{CountryName}
//</div><br><br>