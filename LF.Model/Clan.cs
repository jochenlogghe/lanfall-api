using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LF.Model
{
    /// <summary>
    /// Model to define Clans
    /// </summary>
    public class Clan : Entity
    {
        public string Name { get; set; }

        public int FounderId { get; set; }
        public User Founder { get; set; }

        public ICollection<User> Members { get; set; }
        public ICollection<Competition> Competitions { get; set; }
    }
}
