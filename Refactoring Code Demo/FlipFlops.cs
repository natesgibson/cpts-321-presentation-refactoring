// <copyright file="FlipFlops.cs" company="PlaceholderCompany">
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
    /// Class which represents flip flops product.
    /// </summary>
    public class FlipFlops : Product
    {
        /// <summary>
        /// Returns the price of flip flops.
        /// </summary>
        /// <returns>Flip flops price.</returns>
        public new double GetPrice()
        {
            return 5.99;
        }
    }
}
