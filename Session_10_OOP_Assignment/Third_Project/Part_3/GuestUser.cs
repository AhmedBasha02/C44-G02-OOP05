using Session_10_OOP_Assignment.Third_Project.Part_1;
using Session_10_OOP_Assignment.Third_Project.Part_2;

namespace Session_10_OOP_Assignment.Third_Project.Part_3
{
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(0);
        }
    }
}
