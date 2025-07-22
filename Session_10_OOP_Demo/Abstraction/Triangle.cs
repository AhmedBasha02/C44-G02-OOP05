namespace Session_10_OOP_Demo.Abstraction
{
    internal class Triangle : Shape
    {
        public decimal Dimension3{ get; set; }

        public override decimal Perimeter => throw new NotImplementedException();

        public Triangle(decimal dim1 , decimal dim2 , decimal dim3) : base(dim1 , dim2)
        {
            Dimension3 = dim3;
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }
    }
}
