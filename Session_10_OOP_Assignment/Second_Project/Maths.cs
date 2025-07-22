namespace Session_10_OOP_Assignment.Second_Project
{
    internal static class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            if (a != 0)
            {
                return (double)b / a;
            }
            return double.NaN;
        }

    }
}
