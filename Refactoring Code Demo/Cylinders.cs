// <copyright file="Cylinders.cs" company="PlaceholderCompany">
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
    /// Provides computations for cylinder object.
    /// </summary>
    public static class Cylinders
    {
        /// <summary>
        /// Gets the surface area of a Cylinder.
        /// </summary>
        /// <param name="c">
        /// A cylinder.
        /// </param>
        /// <returns>
        /// Surface area of the cylinder.
        /// </returns>
        public static double GetSurfaceArea(Cylinder c)
        {
            return (2 * Math.PI * c.Radius * c.Height) + (2 * Math.PI * c.Radius * c.Radius);
        }

        /// <summary>
        /// Gets the surface area of a Cylinder (Refactored).
        /// </summary>
        /// <param name="c">
        /// A cylinder.
        /// </param>
        /// <returns>
        /// Surface area of the cylinder.
        /// </returns>
        public static double GetSurfaceAreaRefactored(Cylinder c)
        {
            double rSquared = c.Radius * c.Radius;

            double baseArea = Math.PI * rSquared;

            double baseCircumfrence = 2 * Math.PI * c.Radius;

            return (baseCircumfrence * c.Height) + (2 * baseArea);
        }
    }
}
