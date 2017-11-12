using System;

namespace shapes
{
    class Circle : Geometry
    {
        private double _perimeter;
        private double _area;
        private DateTime _timeStamp;
        public Circle(double perimeter, double area)
            : base("Circle")
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
            return String.Format("{0,-33}{1,-12}{2,-20}{3,-12}{4,-25}{5,21}",
                                  "Circle", "Perimeter:", _perimeter,
                                  "Area:", _area, _timeStamp);
        }
    }
}
