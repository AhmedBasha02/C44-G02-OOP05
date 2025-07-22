using Session_10_OOP_Assignment.Third_Project.Part_1;

namespace Session_10_OOP_Assignment.Third_Project.Part_2
{
    internal class PercentageDiscount : Discount
    {
        private readonly decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            Name = "Percentage Discount";
            this.percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}
