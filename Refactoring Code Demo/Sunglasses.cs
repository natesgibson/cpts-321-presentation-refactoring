// <copyright file="Sunglasses.cs" company="PlaceholderCompany">
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
    /// Class which represents sunglasses product.
    /// </summary>
    public class Sunglasses : Product
    {
        /// <summary>
        /// Returns the price of sunglasses.
        /// </summary>
        /// <returns>Sunglasses price.</returns>
        public new double GetPrice()
        {
            return 11.99;
        }
    }
}
