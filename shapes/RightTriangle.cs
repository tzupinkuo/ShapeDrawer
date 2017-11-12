using System;

namespace shapes
{
    class RightTriangle : Geometry
    {
        private double _perimeter;
        private double _area;
        private DateTime _timeStamp;        

        public RightTriangle (double perimeter, double area)
            : base("Right Triangle")
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
            return String.Format("{0,-26}{1,-12}{2,-20}{3,-12}{4,-25}{5,25}",
                                  "Right Triangle", "Perimeter:", _perimeter,
                                  "Area:", _area, _timeStamp);
        }
    }
}
