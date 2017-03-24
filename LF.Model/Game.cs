namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to identify Games
    /// </summary>
    public class Game: Entity
    {
        /// <summary>
        /// The Name of the Game
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The Competitions the game was played in
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }
    }
}
