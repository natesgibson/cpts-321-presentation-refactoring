// <copyright file="ConsoleMenu.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Peyton Urquhart, 11622450

namespace Refactoring_Code_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// ConsoleMenu object for displaying a menu withing a console application.
    /// </summary>
    public class ConsoleMenu
    {
        private int minRange = 0; // minRange holds the minimum valid selection on the ConsoleMenu
        private int maxRange = 0;   // maxRange holds the maximum valid selection on the ConsoleMenu
        private string menuOptions; // menuOptions holds a string which is used to display all of the options on the menu
        private string label = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleMenu"/> class.
        /// </summary>
        /// <param name="min">
        /// The minimum selection in the menu.
        /// </param>
        /// <param name="max">
        /// The maximum selection in the menu.
        /// </param>
        public ConsoleMenu(int min, int max)
        {
            this.minRange = min;
            this.maxRange = max;
        }

        /// <summary>
        /// Sets the label which is printed before the menu in PrintMenu().
        /// </summary>
        public string Label
        {
            private get
            {
                if (this.label == null)
                {
                    return string.Empty;
                }

                return this.label;
            }

            set
            {
                this.label = value;
            }
        }

        /// <summary>
        /// Accepts a string (which is a new option to be added to the menu) and appends it to the classes encapsulated 'menuOptions' string along with required newline character.
        /// </summary>
        /// <param name="s">
        /// A string representing a new menu selection.
        /// </param>
        public void PushMenuSelection(string s)
        {
            this.menuOptions += Environment.NewLine;
            this.menuOptions += s;
        }

        /// <summary>
        /// Prints all menu options to the console window.
        /// </summary>
        public void PrintMenu()
        {
            Console.WriteLine(this.Label);
            Console.WriteLine(this.menuOptions);
        }

        /// <summary>
        /// Reads in a buffer from stdin and attempts to parse it into a valid integer selection. If the input is valid it will return the input (out int input), else -1.
        /// </summary>
        /// <param name="input">
        /// Outputs any valid input which is entered.
        /// </param>
        /// <returns>
        /// A valid user menu input or -1 for an invalid input.
        /// </returns>
        public int GetMenuOption(out int input)
        {
            string buf = Console.ReadLine(); // Read in a string buffer from stdin.

            int userInput = -1;

            // If the attempt at parsing the input is unsuccessful return -1.
            if (!int.TryParse(buf, out userInput))
            {
                input = -1;
                return -1;
            }
            else if (!this.IsValidInput(userInput))
            {
                input = -1;
                return -1;
            }
            else
            {
                input = userInput;
                return userInput;
            }
        }

        /// <summary>
        /// Returns 'true' if the input is within range and 'false' if the input is out of range.
        /// </summary>
        private bool IsValidInput(int n)
        {
            if (n < this.minRange || n > this.maxRange)
            {
                return false;
            }

            return true;
        }
    }
}