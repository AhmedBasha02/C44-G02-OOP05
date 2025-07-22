namespace Session_10_OOP_Demo.Static
{
    internal class Test : Utility
    {
        // make Constructor to Remove error when inherit from Utility
        // 3aml Constructor Chaining 
        // base(x,y) to call the base class constructor
        // and pass the parameters to it
        // this is a constructor that takes two parameters x and y
        // and calls the base class constructor
        // and pass the parameters to it

        public Test(int x , int y) : base(x,y)
        {

        }
    }
}
