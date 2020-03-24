// <copyright file="TriangleRefactored.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Refactored Triangle class.
    /// </summary>
    internal class TriangleRefactored : Shape
    {
        /// <summary>
        /// Gets or sets color variable.
        /// </summary>
        public override string Color { get; set; } = "red";

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public override bool IsShape { get; set; } = true;

        /// <summary>
        /// gets or sets Radius variable.
        /// </summary>
        public long Radius { get; set; } = 1;

        /// <summary>
        /// Display's shape in console.
        /// </summary>
        public override void DisplayShape()
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
