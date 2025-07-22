using Session_10_OOP_Assignment.Third_Project.Part_1;

namespace Session_10_OOP_Assignment.Third_Project.Part_2
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }
}
