// <copyright file="Pants.cs" company="PlaceholderCompany">
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
    /// Class which represents pants product.
    /// </summary>
    public class Pants : Product
    {
        /// <summary>
        /// Returns the price of pants.
        /// </summary>
        /// <returns>Pants price.</returns>
        public new double GetPrice()
        {
            return 19.99;
        }
    }
}
