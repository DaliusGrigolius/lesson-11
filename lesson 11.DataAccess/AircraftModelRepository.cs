using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aircraftModels { get; }

        public AircraftModelRepository()
        {
            aircraftModels = new List<AircraftModel>();

            aircraftModels.Add(new AircraftModel("T1-5505", "Very fast aircraft"));
            aircraftModels.Add(new AircraftModel("T2-6606", "Very slow aircraft"));
            aircraftModels.Add(new AircraftModel("T3-7707", "Very special aircraft"));
        }

        public List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }

        public AircraftModel Retrieve(int number)
        {
            return aircraftModels[number];
        }
    }
}
