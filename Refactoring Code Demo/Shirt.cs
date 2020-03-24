// <copyright file="Shirt.cs" company="PlaceholderCompany">
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
    /// Class which represents a shirt product.
    /// </summary>
    public class Shirt : Product
    {
        /// <summary>
        /// Returns the price of the shirt.
        /// </summary>
        /// <returns>Shirt price.</returns>
        public new double GetPrice()
        {
            return 14.99;
        }
    }
}
