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
            get;
        }
        public double Length
        {
            get
            { return _length; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("_length måste vara mer än 0");
                   
                }
                _length = value;
            }
        }
        public abstract double Perimeter
        {
            get;
        }
        public double Width
        {
            get
            { return _width; }

            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("_width måste vara mer än 0");
                }
                _width = value; 
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

            string toString = "\nLängd  :     " + Length + "\n" +
                              "Bredd  :     " + Width + "\n" +
                              "Omrekts:     " + Perimeter + "\n" +
                              "Area   :     " + Area + "\n";
            return toString;
        }
    }
}
