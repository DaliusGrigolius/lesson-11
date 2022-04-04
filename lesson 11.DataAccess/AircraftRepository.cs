using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class AircraftRepository
    {
        private List<AirCraft> airCrafts { get; }       

        public AircraftRepository()
        {
            airCrafts = new List<AirCraft>();

            AircraftModel aircraftModel1 = new AircraftModel("T1-5505", "Very fast aircraft");
            AircraftModel aircraftModel2 = new AircraftModel("T2-6606", "Very slow aircraft");
            AircraftModel aircraftModel3 = new AircraftModel("T3-7707", "Very special aircraft");

            Country country1 = new Country("LT", "Lietuva");
            Country country2 = new Country("EN", "Anglija");
            Country country3 = new Country("PL", "Lenkija");

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

        public List<int> RetrieveAircraftsFromEsCountries()
        {
            CountryRepository countryRepository = new CountryRepository();
            List<Country> esCountriesList = countryRepository.esCountries;

            List<int> filteredEsCountriesAircraftsIds = new List<int>();

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
    }
}
