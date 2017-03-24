namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define Users
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// The UserName of the User
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// The Emailaddress of the User
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Reference to the Clan where the user is Founder of
        /// </summary>
        public int? FounderOfClanId { get; set; }
        public Clan FounderOfClan { get; set; }

        /// <summary>
        /// Reference to the Clan the user is Member of
        /// </summary>
        public int? ClanId { get; set; }
        public Clan Clan { get; set; }

        /// <summary>
        /// Reference to the UserDetails of the User
        /// </summary>
        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; }

        /// <summary>
        /// Collection of the Users Seats
        /// </summary>
        public ICollection<Seat> Seats { get; set; }

        /// <summary>
        /// Collection of the Users Roles
        /// </summary>
        public ICollection<Role> Roles { get; set; }

        /// <summary>
        /// Collection of Competitions the User Participates in
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }

        /// <summary>
        /// Collection of Competitions the User is Admin of
        /// </summary>
        public ICollection<CompetitionAdmin> AdminOfCompetitions { get; set; }
    }
}
