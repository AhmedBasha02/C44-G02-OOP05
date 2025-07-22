namespace Session_10_OOP_Assignment.First_Project
{
    internal class _3DPoint : ICloneable, IComparable<_3DPoint>

    {
        #region properties
        public int Point1 { get; }
        public int Point2 { get; }
        public int Point3 { get; }
        #endregion

        #region Constructors
        public _3DPoint(int point1, int point2, int point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }
        public _3DPoint() 
        { }

        public _3DPoint(int point1) : this(point1 , 0 , 0)
        { }
        public _3DPoint(int point1, int point2) : this(point1, point2, 0)
        { }
        #endregion

        #region Methods

        public override string ToString() => $"Point Coordinates: ({Point1}, {Point2}, {Point3})";

        public override bool Equals(object? obj)
        {
            if (obj is _3DPoint p)
            {
                return Point1 == p.Point1 && Point2 == p.Point2 && Point3 == p.Point3;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Point1, Point2, Point3).GetHashCode();
        }

        public static bool operator == (_3DPoint a, _3DPoint b)
        {
            return a.Equals(b);
        }

        public static bool operator != (_3DPoint a, _3DPoint b)
        {
            return !a.Equals(b);
        }

        public object Clone() => new _3DPoint(Point1, Point2, Point3);


        public int CompareTo(_3DPoint other)
        {
            int cmpP1 = Point1.CompareTo(other.Point1);
            return cmpP1 != 0 ? cmpP1 : Point2.CompareTo(other.Point2);
        }


        #endregion
    }
}
