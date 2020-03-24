// <copyright file="SquareRefactored.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Square class.
    /// </summary>
    internal class SquareRefactored : ShapeRefactored
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareRefactored"/> class.
        /// </summary>
        /// <param name="color"></param>
        public SquareRefactored(ConsoleColor color = ConsoleColor.Blue) : base(color) { }

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public override bool IsShape { get; set; } = true;

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
        public override void DisplayShape()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
