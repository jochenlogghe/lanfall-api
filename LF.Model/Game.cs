using System.Collections.Generic;

namespace LF.Model
{
    public class Game: Entity
    {
        public string Name { get; set; }

        public ICollection<Competition> Competitions { get; set; }
    }
}
