using Session_10_OOP_Assignment.First_Project;
using Session_10_OOP_Assignment.Second_Project;
using Session_10_OOP_Assignment.Third_Project.Part_1;
using Session_10_OOP_Assignment.Third_Project.Part_3;
using Session_10_OOP_Assignment.Third_Project.User_Type;
using System.Security.Cryptography.X509Certificates;

namespace Session_10_OOP_Assignment
{
    internal class Program
    {
        #region Method First Project
        public static _3DPoint TakePointFromUser()
        {
            int num1 , num2 , num3 ;
            bool isParsed;
            do
            {
                Console.WriteLine("Please Enter X for this point : \n");
                isParsed = int.TryParse(Console.ReadLine(), out num1);
            }
            while (!isParsed);
            do
            {
                Console.WriteLine("Please Enter Y for this point : \n");
                isParsed = int.TryParse(Console.ReadLine(), out num2);
            }
            while (!isParsed);
            do
            {
                Console.WriteLine("Please Enter Z for this point : \n");
                isParsed = int.TryParse(Console.ReadLine(), out num3);
            }
            while (!isParsed);
            return new _3DPoint(num1, num2, num3);
        }
        #endregion
        static void Main(string[] args)
        {
            #region First Project

            //_3DPoint point1 = TakePointFromUser();
            //_3DPoint point2 = TakePointFromUser();
            //_3DPoint point3 = TakePointFromUser();

            //Console.WriteLine();
            //Console.WriteLine(point1.ToString());
            //Console.WriteLine();
            //Console.WriteLine(point2.ToString());
            //Console.WriteLine();
            //Console.WriteLine(point3.ToString());
            //Console.WriteLine();

            //_3DPoint[] points = { point1, point2, point3 };
            //Array.Sort(points);
            //foreach (var pt in points)
            //{
            //    Console.WriteLine(pt);
            //}

            //Console.WriteLine();

            //_3DPoint p1 = new _3DPoint(1, 5, 9);
            //_3DPoint p2 = new _3DPoint(1, 5, 9);
            //_3DPoint p3 = new _3DPoint(2, 6, 9);
            //Console.WriteLine();
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine();
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine();
            //Console.WriteLine(p3.ToString());
            //Console.WriteLine();
            //Console.WriteLine($"Are p1 and p2 equal? {p1 == p2}");
            //Console.WriteLine();
            //Console.WriteLine($"Are p1 and p3 equal? {p1 == p3}");

            #endregion

            #region Second Project

            //Console.WriteLine($"Sum of 2 numbers = {Maths.Add(5, 3)}");
            //Console.WriteLine();
            //Console.WriteLine($"Sub of 2 numbers = {Maths.Subtract(10, 4)}");
            //Console.WriteLine();
            //Console.WriteLine($"Mul of 2 numbers = {Maths.Multiply(6, 2)}");
            //Console.WriteLine();
            //Console.WriteLine($"Div of 2 numbers = {Maths.Divide(8, 2)}");
            //Console.WriteLine();


            #endregion

            #region Third Project

            //UserType userType;
            //bool isParsed;
            //do
            //{
            //    Console.WriteLine("Enter Your Type , Are you [Regular , Premium , Guest] : \n");
            //    isParsed = Enum.TryParse<UserType>(Console.ReadLine(), true, out userType);
            //}
            //while (!isParsed);
            //Console.WriteLine();

            //User user = userType switch
            //{
            //    UserType.Regular => new RegularUser(),
            //    UserType.Premium => new PremiumUser(),
            //    UserType.Guest => new GuestUser(),
            //    _ => throw new ArgumentException("Invalid user type")
            //};

            //Console.WriteLine();

            //decimal price;
            //bool isPriceParsed;
            //do
            //{
            //    Console.WriteLine($"Enter Product Price : \n");
            //    isPriceParsed = decimal.TryParse(Console.ReadLine(), out price);
            //}
            //while (!isPriceParsed);
            //Console.WriteLine();

            //int quantity;
            //bool isQuantityParsed;
            //do
            //{
            //    Console.WriteLine($"Enter Quantity : \n");
            //    isQuantityParsed = int.TryParse(Console.ReadLine(), out quantity);
            //}
            //while (!isQuantityParsed);
            //Console.WriteLine();

            //Discount discount = user.GetDiscount();

            //decimal discountAmount = discount.CalculateDiscount(price, quantity);
            //decimal finalPrice = price * quantity - discountAmount;

            //Console.WriteLine($"Discount Applied: {discount.Name}");
            //Console.WriteLine();
            //Console.WriteLine($"Discount Amount: {discountAmount}");
            //Console.WriteLine();
            //Console.WriteLine($"Final Price: {finalPrice}");
            //Console.WriteLine();


            #endregion



        }
    }
}
