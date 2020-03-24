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
            int maxOption = 1;

            ConsoleMenu menu = new ConsoleMenu(minOption, maxOption);

            menu.Label = "Code Refactorings Demo!";

            menu.PushMenuSelection("1) Extract Variable");
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
                }
            }
        }
    }
}
