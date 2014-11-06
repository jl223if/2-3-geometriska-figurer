using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
    class Ellipse : Shape
    {

        public override double Area
        {
            get { throw new NotImplementedException(); }
        }

        public override double Perimeter
        {
            get { throw new NotImplementedException(); }
        }

        public Ellipse(double length, double width)
            : base(0, 0)
        {
            Length = length;
             Width = width;
        }
    }
}
