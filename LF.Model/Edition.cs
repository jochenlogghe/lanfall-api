namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to create Editions
    /// </summary>
    public class Edition: Entity
    {
        /// <summary>
        /// The Year of the Edition
        /// </summary>
        [Required]
        [Range(2000, 2100)]
        public int Year { get; set; }

        /// <summary>
        /// The Name of the Edition
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The Amount of Participants for that Edition
        /// </summary>
        [Required]
        public int NumberOfParticipants { get; set; }

        /// <summary>
        /// The Competitions during that Edition
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }
    }
}
