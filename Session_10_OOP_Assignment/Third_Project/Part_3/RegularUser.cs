using Session_10_OOP_Assignment.Third_Project.Part_1;
using Session_10_OOP_Assignment.Third_Project.Part_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10_OOP_Assignment.Third_Project.Part_3
{
    internal class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
