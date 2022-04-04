using lesson_11.Business;
using System;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aircraftModels { get; }

        public AircraftModelRepository()
        {
            aircraftModels = new List<AircraftModel>();

            aircraftModels.Add(new AircraftModel("1", "very fast aircraft"));
            aircraftModels.Add(new AircraftModel("2", "very slow aircraft"));
            aircraftModels.Add(new AircraftModel("3", "very special aircraft"));
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
