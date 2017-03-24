using System.Collections.Generic;

namespace LF.Model
{
    public class Edition: Entity
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public int NumberOfParticipants { get; set; }

        public ICollection<Competition> Competitions { get; set; }
    }
}
