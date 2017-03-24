using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF.Model
{
    public abstract class Entity
    {
        public Entity()
        {
            CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
