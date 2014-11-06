using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
     abstract class Shape
    {

        //Variabler
        private double _length;
        private double _width;

        //Egenskaper
        public abstract double Area 
        {
            get
            { 
                double area = _length * Width;
                return area;
            }
        }
        public double Length
        {
            get
            { return _length; }

            set
            {
                if (_length > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("_length måste vara mer än 0");
                }
            }
        }
        public abstract double Perimeter
        {
            get
            {
                double result = (_length * 2) + (_width * 2);
                return result;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }

            set
            {

                if (_width > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("_width måste vara mer än 0");
                }
            }
        }

        //Constructors

         protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {

            string toString = "Längd  :     " + Length + "/n" +
                              "Bredd  :     " + Width + "/n" +
                              "Omrekts:     " + Perimeter + "/n" +
                              "Area   :     " + Area;
            return toString;
        }
    }
}
