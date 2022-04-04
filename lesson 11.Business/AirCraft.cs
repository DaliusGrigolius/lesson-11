using System;

namespace lesson_11.Business
{
    public class AirCraft
    {
        public int AirCraftTailNumber { get; }
        public Model AirCraftModel { get; }
        public Company AirCraftOwnerCompany { get; }

        public AirCraft(int airCraftTailNumber, Model airCraftModel, Company airCraftownerCompany)
        {
            AirCraftTailNumber = airCraftTailNumber;
            AirCraftModel = airCraftModel;
            AirCraftOwnerCompany = airCraftownerCompany;
        }
    }
}
