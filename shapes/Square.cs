using System;

namespace shapes
{
    class Square : Geometry
    {
        private double _perimeter;
        private double _area;
        private DateTime _timeStamp;
        public Square(double perimeter, double area)
            : base("Square")
        {
            _perimeter = perimeter;
            _area = area;
            _timeStamp = DateTime.Now;
        }

        public override double Perimeter
        {
            get { return _perimeter; }            
        }

        public override double Area
        {
            get { return _area; }           
        }

        public DateTime GetTimeStamp
        {
            get { return _timeStamp; }
        }
        public override string toString()
        {
            return String.Format("{0,-30}{1,-13}{2,-21}{3,-12}{4,-25}{5,24}",
                                  "Square", "Perimeter:", _perimeter,
                                  "Area:", _area, _timeStamp);
        }
    }
}
