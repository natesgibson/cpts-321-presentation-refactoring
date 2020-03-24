// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Traingle class (misspelled intentionally for a demo).
    /// Can be renamed using one of Visual Studio's refactoring tools.
    /// </summary>
    internal class Traingle
    {
        /// <summary>
        /// Gets or sets color variable.
        /// </summary>
        public string Color { get; set; } = "red";

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public bool IsShape { get; set; } = true;

        /// <summary>
        /// gets or sets SideLength variable.
        /// </summary>
        public long Sidelength { get; set; } = 1;

        /// <summary>
        /// Display's shape in console.
        /// </summary>
        public void DisplayShape()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
