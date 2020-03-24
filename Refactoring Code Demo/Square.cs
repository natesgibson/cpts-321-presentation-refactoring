// <copyright file="Square.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Square class.
    /// </summary>
    internal class Square
    {
        /// <summary>
        /// Gets or sets color variable.
        /// </summary>
        public string Color { get; set; } = "blue";

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public bool IsShape { get; set; } = true;

        /// <summary>
        /// Gets or sets height variable.
        /// </summary>
        public long Height { get; set; } = 1;

        /// <summary>
        /// Gets or sets Width variable.
        /// </summary>
        public long Width { get; set; } = 1;

        /// <summary>
        /// Display's shape in console.
        /// </summary>
        public void DisplayShape()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
