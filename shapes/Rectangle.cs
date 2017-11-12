using System;

namespace shapes
{
    class Rectangle : Geometry
    {
        private double _perimeter;
        private double _area;
        private DateTime _timeStamp;
        public Rectangle(double perimeter, double area)
            : base("Rectangle")
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
            return String.Format("{0,-29}{1,-13}{2,-21}{3,-12}{4,-25}{5,24}",
                                  "Rectangle", "Perimeter:", _perimeter,
                                  "Area:", _area, _timeStamp);
        }
    }
}
