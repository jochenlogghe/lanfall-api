using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LF.Model
{
    public class User : Entity
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public int? FounderOfClanId { get; set; }
        public Clan FounderOfClan { get; set; }

        public int? ClanId { get; set; }
        public Clan Clan { get; set; }

        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; }

        public ICollection<Seat> Seats { get; set; }

        public ICollection<Role> Roles { get; set; }

        public ICollection<Competition> Competitions { get; set; }
        public ICollection<CompetitionAdmin> AdminOfCompetitions { get; set; }
    }
}
