namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define Clans
    /// </summary>
    public class Clan : Entity
    {
        /// <summary>
        /// Name of the Clan
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Reference to Founder of the Clan, Required
        /// </summary>
        public int FounderId { get; set; }
        public User Founder { get; set; }

        /// <summary>
        /// Clan Members
        /// </summary>
        public ICollection<User> Members { get; set; }

        /// <summary>
        /// Competitions the Clan participates on
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }
    }
}
