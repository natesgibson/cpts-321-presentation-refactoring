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
    internal class TriangleRefactored : ShapeRefactored
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleRefactored"/> class.
        /// </summary>
        /// <param name="color"></param>
        public TriangleRefactored(ConsoleColor color = ConsoleColor.Red) : base(color) { }

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public override bool IsShape { get; set; } = true;

        /// <summary>
        /// gets or sets SideLength variable.
        /// </summary>
        public long SideLength { get; set; } = 1;

        /// <summary>
        /// Display's shape in console.
        /// </summary>
        public override void DisplayShape()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
