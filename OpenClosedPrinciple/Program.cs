using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(15, 20);
            Circle ci = new Circle(3);
            Square s = new Square(5);
            Console.WriteLine("Circle are is:" + ci.Area());
            Console.WriteLine("Rectangle area is:" + rc.Area());
            Console.WriteLine("Square area is:" + s.Area());
            Console.Read();
        }
    }
}
