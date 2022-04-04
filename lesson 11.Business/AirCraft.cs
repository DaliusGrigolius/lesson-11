
namespace lesson_11.Business
{
    public class AirCraft
    {
        public int TailNumber { get; }
        public AircraftModel Model { get; }
        public Company OwnerCompany { get; }

        public AirCraft(int tailNumber, AircraftModel model, Company ownerCompany)
        {
            TailNumber = tailNumber;
            Model = model;
            OwnerCompany = ownerCompany;
        }
    }
}
