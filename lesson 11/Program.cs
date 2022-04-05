using System;

namespace lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            DataPrinter dataPrinter = new DataPrinter();

            dataPrinter.PrintFilteredEuCountries();
            dataPrinter.PrintEuAircraftsIds();
            dataPrinter.PrintReportAboutEuAircrafts();
            dataPrinter.PrintAircraftsData();
            
            Console.ReadLine();
        }
    }
}
