// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Code_Demo
{
    /// <summary>
    /// Abstract class which represends a product.
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Returns the price of the product.
        /// </summary>
        /// <returns>Product price.</returns>
        public double GetPrice()
        {
            return -1.0;
        }
    }
}
