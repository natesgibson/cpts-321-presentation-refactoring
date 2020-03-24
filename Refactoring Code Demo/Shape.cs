// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mykhailo Bykhovtsev, 11558171

namespace Refactoring_Code_Demo
{
    /// <summary>
    /// Abstract shape class.
    /// </summary>
    internal abstract class Shape
    {
        /// <summary>
        /// Gets or sets a value indicating whether this is a shape.
        /// </summary>
        public abstract bool IsShape { get; set; }

        /// <summary>
        /// Gets or sets color variable.
        /// </summary>
        public abstract string Color { get; set; }

        /// <summary>
        /// Absctract method to display Shape.
        /// </summary>
        public abstract void DisplayShape();
    }
}
