namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class to model Competitions
    /// </summary>
    public class Competition : Entity
    {
        /// <summary>
        /// The Name of the Competition
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Short Description of the Competition
        /// </summary>
        [Required]
        [StringLength(100)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Long Description of the Competition
        /// </summary>
        [StringLength(2000)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The Header Image Url for the Competition
        /// </summary>
        public string HeaderImageUrl { get; set; }

        /// <summary>
        /// Reference to the Competition Type
        /// </summary>
        public int CompetitionTypeId { get; set; }
        public CompetitionType CompetitionType { get; set; }

        /// <summary>
        /// Reference to the Competition Game
        /// </summary>
        public int? GameId { get; set; }
        public Game Game { get; set; }

        /// <summary>
        /// Reference to the Competitions Edition
        /// </summary>
        public int EditionId { get; set; }
        public Edition Edition { get; set; }

        /// <summary>
        /// The Competition Admins
        /// </summary>
        public ICollection<CompetitionAdmin> CompetitionAdmins { get; set; }

        /// <summary>
        /// The Competitions Participating Users
        /// </summary>
        public ICollection<User> ParticipatingUsers { get; set; }

        /// <summary>
        /// The Competitions Participating Clans
        /// </summary>
        public ICollection<Clan> ParticipatingClans { get; set; }
    }
}
