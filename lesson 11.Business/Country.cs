
namespace lesson_11.Business
{
    public class Country
    {
        public string Code { get; }
        public string Name { get; }
        public bool RegistrationCountry { get; }

        public Country(string code, string name, bool registrationCountry)
        {
            Code = code;
            Name = name;
            RegistrationCountry = registrationCountry;
        }
    }
}
