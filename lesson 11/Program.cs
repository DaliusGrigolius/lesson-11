using lesson_11.DataAccess;
using System;

namespace lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
            Console.WriteLine(aircraftModelRepository.Retrieve(1).Number);
        }
    }
}
