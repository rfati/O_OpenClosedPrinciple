using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Square : Shape
    {
        public double Edge { get; set; }
        public Square(double edge)
        {
            Edge = edge;
        }
        public override double Area()
        {
            return Edge * Edge;
        }
    }
}
