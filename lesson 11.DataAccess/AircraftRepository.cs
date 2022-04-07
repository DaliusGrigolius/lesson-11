using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class AircraftRepository
    {
        public CountryRepository countryRepository { get; }
        private List<AirCraft> airCrafts { get; }
        private List<AirCraft> filteredEuAircrafts { get; }
        private List<AirCraft> filteredNotEuAircrafts { get; }

        public AircraftRepository()
        {
            countryRepository = new CountryRepository();
            airCrafts = new List<AirCraft>();
            filteredEuAircrafts = new List<AirCraft>();
            filteredNotEuAircrafts = new List<AirCraft>();

            AircraftModel aircraftModel1 = new AircraftModel("T1-5505", "Very fast aircraft");
            AircraftModel aircraftModel2 = new AircraftModel("T2-6606", "Very slow aircraft");
            AircraftModel aircraftModel3 = new AircraftModel("T3-7707", "Very special aircraft");

            Country country1 = new Country("LT", "Lithuania", true);
            Country country2 = new Country("GB", "Great Britain", false);
            Country country3 = new Country("PL", "Poland", true);

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

        public List<AirCraft> FilterEuAircrafts()
        {
            if (filteredEuAircrafts.Count > 0)
            {
                filteredEuAircrafts.Clear();
            }

            for (int i = 0; i < airCrafts.Count; i++)
            {
                if (airCrafts[i].OwnerCompany.Country.RegistrationCountry)
                {
                    filteredEuAircrafts.Add(airCrafts[i]);
                }
            }
            return filteredEuAircrafts;
        }

        public List<AirCraft> FilterNotEuAircrafts()
        {
            if (filteredNotEuAircrafts.Count > 0)
            {
                filteredNotEuAircrafts.Clear();
            }

            for (int i = 0; i < airCrafts.Count; i++)
            {
                if (!airCrafts[i].OwnerCompany.Country.RegistrationCountry)
                {
                    filteredNotEuAircrafts.Add(airCrafts[i]);
                }
            }
            return filteredNotEuAircrafts;
        }
    }
}
