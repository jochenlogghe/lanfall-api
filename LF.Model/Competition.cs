using System.Collections.Generic;

namespace LF.Model
{
    public class Competition : Entity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string HeaderImageUrl { get; set; }

        public int CompetitionTypeId { get; set; }
        public CompetitionType CompetitionType { get; set; }

        public int? GameId { get; set; }
        public Game Game { get; set; }

        public int EditionId { get; set; }
        public Edition Edition { get; set; }

        public ICollection<CompetitionAdmin> CompetitionAdmins { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Clan> Clans { get; set; }
    }
}
