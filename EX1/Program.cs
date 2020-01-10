using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(8,"red");
            Console.WriteLine(c1.getPerimeter());
            Console.WriteLine(c1.Color);

            Square s1 = new Square(4,"grey");
            Console.WriteLine(s1.getPerimeter());
            Console.WriteLine(s1.Color);
        }
    }
}
