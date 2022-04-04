using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11.Business
{
    public class Company
    {
        public string CompanyName { get; }
        public Country Country { get; }

        public Company(string companyName, Country country)
        {
            CompanyName = companyName;
            Country = country;
        }
    }
}
