// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Refactoring_Code_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Entry point for the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function.
        /// </summary>
        public static void Main()
        {
            int minOption = 0;

            // Update this value when you add an option to the menu!
            int maxOption = 5;

            ConsoleMenu menu = new ConsoleMenu(minOption, maxOption);

            menu.Label = "Code Refactorings Demo!";

            menu.PushMenuSelection("1) Extract Variable");
            menu.PushMenuSelection("2) Replace Nested Conditionals with Guard Clauses");
            menu.PushMenuSelection("3) Replace Conditional with Polymorphism");
            menu.PushMenuSelection("4) Replace Constructor with Factory Function");
            menu.PushMenuSelection("5) Extract Superclass");
            menu.PushMenuSelection("0) Exit");

            int userInput = -1;

            while (true)
            {
                Console.Clear();

                menu.PrintMenu();

                menu.GetMenuOption(out userInput);

                Console.Clear();

                // Write the code associated with the menu option created for your test in a corresponding case statement.
                switch (userInput)
                {
                    // EXIT
                    case 0:
                        return;

                    // Extract Variable
                    case 1:
                        Cylinder c1 = new Cylinder(5, 5);

                        Console.WriteLine("Un-refactored method: " + Cylinders.GetSurfaceArea(c1) + Environment.NewLine);

                        Console.WriteLine("Refactored method: " + Cylinders.GetSurfaceAreaRefactored(c1) + Environment.NewLine);

                        Console.ReadKey();

                        break;

                    // Replace Nested Conditionals with Guard Clauses
                    case 2:
                        break;

                    // Replace Conditional with Polymorphism
                    case 3:
                        PrintPrices();
                        Console.ReadKey();
                        break;

                    // Replace Constructor with Factory Function
                    case 4:
                        break;

                    // Extract Superclass
                    case 5:
                        Triangle triangle = new Triangle();
                        Square square = new Square();
                        TriangleRefactored triangleRef = new TriangleRefactored();
                        SquareRefactored squareRef = new SquareRefactored();

                        Console.WriteLine("Un-refactored Triangle and Square:" + Environment.NewLine);

                        triangle.DisplayShape();
                        square.DisplayShape();

                        Console.WriteLine("Refactored Triangle and Square:" + Environment.NewLine);

                        triangleRef.DisplayShape();
                        squareRef.DisplayShape();

                        Console.ReadKey();

                        break;
                }
            }
        }

        /// <summary>
        /// For case 3 - Replace Conditional with Polymorphism:
        /// Prints the prices of 4 products using the conditionals and polymorphism methods.
        /// </summary>
        internal static void PrintPrices()
        {
            Console.WriteLine("Conditionals Prices:");
            Console.WriteLine("  Pants cost:      $" + GetPrice(new Pants()));
            Console.WriteLine("  Shirts cost:     $" + GetPrice(new Shirt()));
            Console.WriteLine("  Flip Flops cost: $" + GetPrice(new FlipFlops()));
            Console.WriteLine("  Sunglasses cost: $" + GetPrice(new Sunglasses()) + "     whoops, forgot to add it to the switch!");
            Console.WriteLine();

            Console.WriteLine("Polymorphism Prices:");
            Console.WriteLine("  Pants cost:      $" + new Pants().GetPrice());
            Console.WriteLine("  Shirts cost:     $" + new Shirt().GetPrice());
            Console.WriteLine("  Flip Flops cost: $" + new FlipFlops().GetPrice());
            Console.WriteLine("  Sunglasses cost: $" + new Sunglasses().GetPrice());
            Console.WriteLine();
        }

        /// <summary>
        /// For case 3 - Replace Conditional with Polymorphism:
        /// Takes a product and returns its price.
        /// </summary>
        /// <param name="product">A product.</param>
        /// <returns>Price of the product.</returns>
        internal static double GetPrice(Product product)
        {
            switch (product)
            {
                case Pants pants:
                    return 19.99;
                case Shirt shirt:
                    return 14.99;
                case FlipFlops flipFlops:
                    return 5.99;
                default: // intentionally forgot Sunglasses type
                    return -1.0;
            }
        }
    }
}
