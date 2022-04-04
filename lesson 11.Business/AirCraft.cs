
namespace lesson_11.Business
{
    public class AirCraft
    {
        public int TailNumber { get; }
        public Model Model { get; }
        public Company OwnerCompany { get; }

        public AirCraft(int tailNumber, Model model, Company ownerCompany)
        {
            TailNumber = tailNumber;
            Model = model;
            OwnerCompany = ownerCompany;
        }
    }
}
