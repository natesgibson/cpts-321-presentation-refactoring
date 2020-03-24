// <copyright file="Player.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Odeysiuss Tuon, 11621966

namespace Refactoring_Code_Demo
{
    /// <summary>
    /// Player class
    /// </summary>
    internal class Player
    {
        public enum PlayerState
        {
            Idle,
            Walking,
            Running,
            Swimming,
            InAir
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
        {
            this.State = PlayerState.Idle;
        }

        /// <summary>
        /// Gets the player's state
        /// </summary>
        public PlayerState State { get; set; }
    }
}