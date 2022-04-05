using lesson_11.Business;
using lesson_11.DataAccess;
using System.Collections.Generic;

namespace lesson_11
{
    public class AircraftsData
    {
        AircraftRepository aircraftRepository = new AircraftRepository();

        public List<string> RetrieveAircraftsDataInStringFormat(List<AirCraft> airCraft)
        {
            List<string> data = new List<string>();

            for (int i = 0; i < aircraftRepository.Retrieve().Count; i++)
            {
                data.Add($"Aircraft: {aircraftRepository.Retrieve()[i].TailNumber}");
                data.Add($"Model: {aircraftRepository.Retrieve()[i].Model.Number}");
                data.Add($"Model Description: {aircraftRepository.Retrieve()[i].Model.Description}");
                data.Add($"Owner Company Name: {aircraftRepository.Retrieve()[i].OwnerCompany.Name}");
                data.Add($"      Country Code: {aircraftRepository.Retrieve()[i].OwnerCompany.Country.Code}");
                data.Add($"      Country Name: {aircraftRepository.Retrieve()[i].OwnerCompany.Country.Name}");
                data.Add("------------------------------------");
            }
            return data;
        }
    }
}
