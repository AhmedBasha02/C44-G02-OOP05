namespace Session_10_OOP_Demo.Sealed
{
    internal class Parent
    {
        // we will make property to be virtual to allow overriding in derived classes
        private int salary; //==> private field or private Attribute
        public virtual int Salary // ==> public property to access the private field
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        // make this method Virtual to allow overriding in derived classes in Child class
        public virtual void MyFun()
        {
            Console.WriteLine("Hello i am a parent");
        }
    }
}
