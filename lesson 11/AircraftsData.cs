using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11
{
    public class AircraftsData
    {       
        public List<string> RetrieveAircraftsDataInStringFormat(List<AirCraft> airCraftsList)
        {
            List<string> data = new List<string>();

            for (int i = 0; i < airCraftsList.Count; i++)
            {
                data.Add($"Aircraft: {airCraftsList[i].TailNumber}");
                data.Add($"Model: {airCraftsList[i].Model.Number}");
                data.Add($"Model Description: {airCraftsList[i].Model.Description}");
                data.Add($"Owner Company Name: {airCraftsList[i].OwnerCompany.Name}");
                data.Add($"      Country Code: {airCraftsList[i].OwnerCompany.Country.Code}");
                data.Add($"      Country Name: {airCraftsList[i].OwnerCompany.Country.Name}\r\n");
            }
            return data;
        }
    }
}
