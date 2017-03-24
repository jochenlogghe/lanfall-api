namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define Competition Types
    /// </summary>
    public class CompetitionType : Entity
    {
        /// <summary>
        /// The Name of the Competition Type
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Collection of Competitions with this Type
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }
    }
}
