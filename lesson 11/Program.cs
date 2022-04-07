using System;

namespace lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            DataPrinter dataPrinter = new DataPrinter();
            HTMLGenerator htmlGenerator = new HTMLGenerator();

            dataPrinter.PrintFilteredEuCountries();
            //dataPrinter.PrintFilteredNotEuCountries();
            dataPrinter.PrintEuAircraftsIds();
            //dataPrinter.PrintNotEuAircraftsIds();
            dataPrinter.PrintReportAboutEuAircrafts();
            //dataPrinter.PrintReportAboutNotEuAircrafts();
            dataPrinter.PrintAllAircraftsData();
            htmlGenerator.GenerateHTMLWithColor();

            Console.ReadLine();
        }
    }
}
