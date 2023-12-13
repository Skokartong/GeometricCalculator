using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Rectangle
    {
        int widthRectangle;
        int heightRectangle;

        public void GetAreaRectangle()
        {
            Console.WriteLine("What is the height?");
            int heightRectangle = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width?");
            int widthRectangle = int.Parse(Console.ReadLine());
            int areaRectangle = widthRectangle * heightRectangle;
            Console.WriteLine("The area of the rectangle is: " + areaRectangle);
        }
    }
}
