namespace Session_10_OOP_Demo.Partial
{
    // el Partial Class 3ady y inherit mn ay Class 3ady 
    internal partial class Employee
    {
        // hena 3andy 1 method 
        // we henak 3and 3 properties
        // el 3ayez 23mloh hwa 2ny 2bd2 2t3aml ma3 el Employee ka kol 
        // el hwa yb2a 4ayef el method we el 3 properties
        // 5las yala han3ml dah fe el Progeam.cs

        public partial void Print()
        {
            Console.WriteLine($"Hello From Employee Method Print");
        }

        public partial int PrintNum()
        {
            return 10;
        }
    }
}
