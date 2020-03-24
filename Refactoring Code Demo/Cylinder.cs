// <copyright file="Cylinder.cs" company="PlaceholderCompany">
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
    /// class which represents a basic right cylinder.
    /// </summary>
    public class Cylinder
    {
        private double radius;

        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cylinder"/> class.
        /// </summary>
        /// <param name="r">
        /// Cylinder radius.
        /// </param>
        /// <param name="h">
        /// Cylinder height.
        /// </param>
        public Cylinder(double r, double h)
        {
            this.radius = r;
            this.height = h;
        }

        /// <summary>
        /// Gets the radius of the cylinder.
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }
        }

        /// <summary>
        /// Gets the height of the cylinder.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }
        }
    }
}
