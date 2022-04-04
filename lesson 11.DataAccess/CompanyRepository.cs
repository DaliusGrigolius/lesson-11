using lesson_11.Business;
using System.Collections.Generic;

namespace lesson_11.DataAccess
{
    public class CompanyRepository
    {
        private List<Company> companys { get; }

        public CompanyRepository()
        {
            companys = new List<Company>();

            Country country1 = new Country("LT", "Lietuva");
            Country country2 = new Country("EN", "Anglija");
            Country country3 = new Country("PL", "Lenkija");

            companys.Add(new Company("company1", country1));
            companys.Add(new Company("company1", country2));
            companys.Add(new Company("company1", country3));
        }

        public List<Company> Retrieve()
        {
            return companys;
        }

        public Company Retrieve(int number)
        {
            return companys[number];
        }
    }
}
