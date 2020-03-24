using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemoExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Triangle triangle = new Triangle();
            Square square = new Square();
            while(input != "exit")
            {
                displayMessages();
                Console.WriteLine("Triangle and Square:");
                triangle.DisplayShape();
                square.DisplayShape();
                Console.Write("Command: ");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("\nTriangle's color is: " + triangle.Color);
                        break;

                    case "2":
                        Console.WriteLine("\nTriangle's radius is: " + triangle.Radius);
                        break;

                    case "3":
                        Console.WriteLine("\nSquare's color is: " + square.Color);
                        break;

                    case "4":
                        Console.WriteLine("\nSquare's height is: " + square.Height);
                        break;

                    case "5":
                        Console.WriteLine("\nSquare's width is: " + square.Width);
                        break;

                    case "6":
                        System.Environment.Exit(1);
                        break;

                    default:
                        break;
                }
            }
        }

        private static void displayMessages()
        {
            Console.WriteLine("Hello, here are the options for this program to display:" + 
                                "\n  1. Triangle color" +
                                "\n  2. Cirlce radius" +
                                "\n  3. Square color" +
                                "\n  4. Square height" +
                                "\n  5. Square width" +
                                "\n  6. Exit program"
                             );
        }
    }
}
