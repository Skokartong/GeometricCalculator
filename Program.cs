using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Lab5
{
    class Program
    {
        // Three classes of geometric objects are created: Circle, Triangle, and Rectangle.
        // All of them share the method 'GetArea' to calculate their respective area.
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

        // Main method
        static void Main(string[] args)
        {
            bool playAgain = true;

            // While-loop 
            while (playAgain)
            {

                Console.WriteLine("Welcome to the area calculator! What would you like to do (1-3)?");
                Console.WriteLine("1. Calculate the area of a circle. 2. Calculate the area of a triangle. 3. Calculate the area of a rectangle.");
                string reply = Console.ReadLine();

                // A switch statement is used to let the user choose which object's area to calculate.
                switch (reply)
                {
                    case "1":
                        Circle circle = new Circle();
                        circle.GetAreaCircle();
                        break;

                    case "2":
                        Triangle triangle = new Triangle();
                        triangle.GetAreaTriangle();
                        break;

                    case "3":
                        Rectangle rectangle = new Rectangle();
                        rectangle.GetAreaRectangle();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                        break;
                }

                Console.WriteLine("Do you wish to continue (Y/N)?");
                string continueChoice = Console.ReadLine();

                if (continueChoice == "Y")
                {
                    playAgain = true;
                }

                else
                {
                    playAgain = false;
                    Console.WriteLine("Bye!");
                }
            }
        }
    }
}