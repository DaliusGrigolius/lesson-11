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
            //List<string> aircraftsListInStringFormat = aircraftsData.RetrieveAircraftsDataInStringFormat(aircraftsList);

            var templatePath = @$"C:\Users\User\Desktop\repos\lesson 11\template.html";
            var reportPath = @$"C:\Users\User\Desktop\repos\lesson 11\report.html";


            for (int i = 0; i < aircraftsList.Count; i++)
            {
                string color = aircraftsList[i].OwnerCompany.Country.RegistrationCountry ? color = "lightblue" : color = "lightcoral";
                var divOpenWithColor = $"<div style =\"background: {color}; padding: 15px; margin: 0 auto; border-radius: 10px; text-align: center;\">";
                var text = File.ReadAllText(templatePath);

                text = text.Replace("{divBgColorOpen}", $"{divOpenWithColor}");
                text = text.Replace("{Aircraft}", $"TailNumber: {aircraftsList[i].TailNumber}");
                text = text.Replace("{Model}", $"Model Number: {aircraftsList[i].Model.Number}");
                text = text.Replace("{ModelDescription}", $"Model Description: {aircraftsList[i].Model.Description}");
                text = text.Replace("{OwnerCompanyName}", $"Owner Company Name: {aircraftsList[i].OwnerCompany.Name}");
                text = text.Replace("{CountryCode}", $"Country Code: {aircraftsList[i].OwnerCompany.Country.Code}");
                text = text.Replace("{CountryName}", $"Country Name: {aircraftsList[i].OwnerCompany.Country.Name}");
                text = text.Replace("{divBgColorClose}", "</div>");

                File.AppendAllText(reportPath, text);
            }
        }
    }
}