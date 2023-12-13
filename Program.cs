using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Lab5
{
    // Program to calculate area of circle, triangle and rectangle using switch menu.
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {

                Console.WriteLine("Welcome to the area calculator! What would you like to do (1-3)?");
                Console.WriteLine("1. Calculate the area of a circle. 2. Calculate the area of a triangle. 3. Calculate the area of a rectangle.");
                string reply = Console.ReadLine();

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