using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Geometry
    {
        private string _shape;   

        public Geometry(string shape)
        {
            _shape = shape;
        }

        public string Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public virtual double Perimeter
        {
            get { return 0.0; }            
        }

        public virtual double Area
        {
            get { return 0.0; }            
        }        

        public virtual string toString()
        {
            return "";
        }       
    }
}
