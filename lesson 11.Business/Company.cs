
namespace lesson_11.Business
{
    public class Company
    {
        public string Name { get; }
        public Country Country { get; }

        public Company(string name, Country country)
        {
            Name = name;
            Country = country;
        }
    }
}
