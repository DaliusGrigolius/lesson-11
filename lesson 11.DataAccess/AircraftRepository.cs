using lesson_11.Business;
using System;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class AircraftRepository
    {
        private List<AirCraft> airCrafts { get; }
        public List<int> filteredEsCountriesAircraftsIds;

        public AircraftRepository()
        {
            airCrafts = new List<AirCraft>();
            filteredEsCountriesAircraftsIds = new List<int>();

            AircraftModel aircraftModel1 = new AircraftModel("T1-5505", "Very fast aircraft");
            AircraftModel aircraftModel2 = new AircraftModel("T2-6606", "Very slow aircraft");
            AircraftModel aircraftModel3 = new AircraftModel("T3-7707", "Very special aircraft");

            Country country1 = new Country("LT", "Lithuania");
            Country country2 = new Country("GB", "Great Britain");
            Country country3 = new Country("PL", "Poland");

            Company company1 = new Company("Profitable", country1);
            Company company2 = new Company("Not Profitable", country2);
            Company company3 = new Company("Almost Profitable", country3);

            airCrafts.Add(new AirCraft(1, aircraftModel1, company1));
            airCrafts.Add(new AirCraft(2, aircraftModel2, company2));
            airCrafts.Add(new AirCraft(3, aircraftModel3, company3));
        }

        public List<AirCraft> Retrieve()
        {
            return airCrafts;
        }

        public AirCraft Retrieve(int number)
        {
            return airCrafts[number];
        }

        public List<int> RetrieveAircraftsFromEuCountries()
        {
            CountryRepository countryRepository = new CountryRepository();
            List<Country> esCountriesList = countryRepository.euCountries;

            for (int i = 0; i < esCountriesList.Count; i++)
            {
                for (int j = 0; j < airCrafts.Count; j++)
                {
                    if (esCountriesList[i].Code == airCrafts[j].OwnerCompany.Country.Code)
                    {
                        filteredEsCountriesAircraftsIds.Add(airCrafts[j].TailNumber);
                    }
                }
            }
            return filteredEsCountriesAircraftsIds;
        }

        public void PrintEuAircraftsIds()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EU Aircrafts ID's list:");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < filteredEsCountriesAircraftsIds.Count; i++)
            {
                Console.WriteLine($"- {filteredEsCountriesAircraftsIds[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }
    }
}
