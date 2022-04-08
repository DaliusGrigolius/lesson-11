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
            var reportPath2 = @$"C:\Users\User\Desktop\repos\lesson 11\report.html";

            var divOpenWithColorEu = "<div style =\"background: lightblue; padding: 15px; margin: 0 auto; border-radius: 10px; text-align: center;\">";
            var divOpenWithColorNotEu = "<div style =\"background: lightcoral; padding: 15px; margin: 0 auto; border-radius: 10px; text-align: center;\">";

            for (int i = 0; i < aircraftsList.Count; i++)
            {
                if (aircraftsList[i].OwnerCompany.Country.RegistrationCountry)
                {
                    var text = File.ReadAllText(templatePath);
                    text = text.Replace("{divBgColorOpen}", $"{divOpenWithColorEu}");
                    text = text.Replace("{Aircraft}", $"TailNumber: {aircraftsList[i].TailNumber}");
                    text = text.Replace("{Model}", $"Model Number: {aircraftsList[i].Model.Number}");
                    text = text.Replace("{ModelDescription}", $"Model Description: {aircraftsList[i].Model.Description}");
                    text = text.Replace("{OwnerCompanyName}", $"Owner Company Name: {aircraftsList[i].OwnerCompany.Name}");
                    text = text.Replace("{CountryCode}", $"Country Code: {aircraftsList[i].OwnerCompany.Country.Code}");
                    text = text.Replace("{CountryName}", $"Country Name: {aircraftsList[i].OwnerCompany.Country.Name}");
                    text = text.Replace("{divBgColorClose}", "</div>");

                    File.AppendAllText(reportPath2, text);
                }
                else
                {
                    var text = File.ReadAllText(templatePath);
                    text = text.Replace("{divBgColorOpen}", $"{divOpenWithColorNotEu}");
                    text = text.Replace("{Aircraft}", $"TailNumber: {aircraftsList[i].TailNumber}");
                    text = text.Replace("{Model}", $"Model Number: {aircraftsList[i].Model.Number}");
                    text = text.Replace("{ModelDescription}", $"Model Description: {aircraftsList[i].Model.Description}");
                    text = text.Replace("{OwnerCompanyName}", $"Owner Company Name: {aircraftsList[i].OwnerCompany.Name}");
                    text = text.Replace("{CountryCode}", $"Country Code: {aircraftsList[i].OwnerCompany.Country.Code}");
                    text = text.Replace("{CountryName}", $"Country Name: {aircraftsList[i].OwnerCompany.Country.Name}");
                    text = text.Replace("{divBgColorClose}", "</div>");

                    File.AppendAllText(reportPath2, text);
                }
            }
        }
    }
}
//{Aircraft}
//{Model}
//{ModelDescription}
//{OwnerCompanyName}
//{CountryCode}
//{CountryName}