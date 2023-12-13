using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Triangle
    {
        int widthTriangle;
        int heightTriangle;

        public void GetAreaTriangle()
        {
            Console.WriteLine("What is the height?");
            int heightTriangle = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the base?");
            int widthTriangle = int.Parse(Console.ReadLine());
            int areaTriangle = (widthTriangle * heightTriangle) / 2;
            Console.WriteLine("The area of the triangle is: " + areaTriangle);
        }
    }
}
