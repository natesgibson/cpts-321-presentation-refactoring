// <copyright file="Boss.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Odeysiuss Tuon, 11621966

namespace Refactoring_Code_Demo
{
    using System;

    /// <summary>
    /// Boss class
    /// </summary>
    internal class Boss
    {
        /// <summary>
        /// Executes the next attack based on the target player's current state.
        /// Can be refactored using "replace nested conditionals with guard clauses".
        /// </summary>
        /// <param name="targetPlayer">The player that the boss is targeting</param>
        /// <returns>True if the boss is able to execute the next attack, false otherwise</returns>
        public bool ExecuteNextAttack(Player targetPlayer)
        {
            if (targetPlayer.State == Player.PlayerState.Idle)
            {
                return Attack1();
            }
            else
            {
                if (targetPlayer.State == Player.PlayerState.Walking)
                {
                    return Attack2();
                }
                else
                {
                    if (targetPlayer.State == Player.PlayerState.Running)
                    {
                        return Attack3();
                    }
                    else
                    {
                        if (targetPlayer.State == Player.PlayerState.Swimming || targetPlayer.State == Player.PlayerState.InAir)
                        {
                            return Attack4();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Attack for when player is idle
        /// </summary>
        /// <returns>True if the boss is able to execute this attack, false otherwise</returns>
        private bool Attack1()
        {
            Console.WriteLine("Boss does attack 1");
            return true;
        }

        /// <summary>
        /// Attack for when player is walking
        /// </summary>
        /// <returns>True if the boss is able to execute this attack, false otherwise</returns>
        private bool Attack2()
        {
            Console.WriteLine("Boss does attack 2");
            return true;
        }

        /// <summary>
        /// Attack for when player is running
        /// </summary>
        /// <returns>True if the boss is able to execute this attack, false otherwise</returns>
        private bool Attack3()
        {
            Console.WriteLine("Boss does attack 3");
            return true;
        }

        /// <summary>
        /// Attack for when player is swimming or in the air
        /// </summary>
        /// <returns>True if the boss is able to execute this attack, false otherwise</returns>
        private bool Attack4()
        {
            Console.WriteLine("Boss does attack 4");
            return true;
        }
    }
}
