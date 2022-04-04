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

            AircraftModel aircraftModel1 = new AircraftModel("1", "description1");
            AircraftModel aircraftModel2 = new AircraftModel("2", "description2");
            AircraftModel aircraftModel3 = new AircraftModel("3", "description3");

            Country country1 = new Country("LT", "Lietuva");
            Country country2 = new Country("EN", "Anglija");
            Country country3 = new Country("PL", "Lenkija");

            Company company1 = new Company("company1", country1);
            Company company2 = new Company("company2", country2);
            Company company3 = new Company("company3", country3);

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
    }
}
