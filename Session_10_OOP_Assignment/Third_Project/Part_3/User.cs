using Session_10_OOP_Assignment.Third_Project.Part_1;

namespace Session_10_OOP_Assignment.Third_Project.Part_3
{
    internal abstract class User
    {
        public string? Name { get; set; }
        public abstract Discount GetDiscount();

    }
}
