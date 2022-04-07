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

            Country country1 = new Country("LT", "Lithuania", true);
            Country country2 = new Country("GB", "Great Britain", false);
            Country country3 = new Country("PL", "Poland", true);

            companys.Add(new Company("Profitable", country1));
            companys.Add(new Company("Not Profitable", country2));
            companys.Add(new Company("Almost Profitable", country3));
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
