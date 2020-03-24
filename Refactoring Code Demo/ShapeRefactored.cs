// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171
// Odeysiuss Tuon, 11621966

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Abstract shape class.
    /// </summary>
    internal abstract class ShapeRefactored
    {
        private ConsoleColor color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        public ShapeRefactored(ConsoleColor color = ConsoleColor.Blue)
        {
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public abstract bool IsShape { get; set; }

        /// <summary>
        /// Gets or sets color of the shape.
        /// </summary>
        public ConsoleColor Color { get => color; set => color = value; }

        /// <summary>
        /// Absctract method to display Shape.
        /// </summary>
        public abstract void DisplayShape();
    }
}
