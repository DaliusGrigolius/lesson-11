
namespace lesson_11.Business
{
    public class AircraftModel
    {
        public string Number { get; }
        public string Description { get; }

        public AircraftModel(string number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
