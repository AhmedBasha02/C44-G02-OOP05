using Session_10_OOP_Assignment.Third_Project.Part_1;
using System.Xml.Linq;

namespace Session_10_OOP_Assignment.Third_Project.Part_2
{
    internal class FlatDiscount : Discount
    {
        private readonly decimal flatAmount;
        public FlatDiscount(decimal amount)
        {
            Name = "Flat Discount";
            flatAmount = amount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}
