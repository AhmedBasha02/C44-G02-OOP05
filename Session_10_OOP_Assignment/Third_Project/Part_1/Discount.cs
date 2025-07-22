namespace Session_10_OOP_Assignment.Third_Project.Part_1
{
    internal abstract class Discount
    {
        public string? Name { get;  set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);

    }
}
