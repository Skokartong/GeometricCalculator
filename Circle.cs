using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Circle
    {
        float pi = 3.141f;
        float radiusCircle;

        public void GetAreaCircle()
        {
            Console.WriteLine("What is the radius of the circle?");
            float radiusCircle = float.Parse(Console.ReadLine());
            float areaCircle = pi * radiusCircle * radiusCircle;
            Console.WriteLine("The area of the circle is: " + areaCircle);
        }
    }
}
