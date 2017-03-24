using System;

namespace LF.Model
{
    /// <summary>
    /// Base Class for every other Class
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Set CreatedOn and ModifiedOn when Entity is created
        /// </summary>
        public Entity()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        /// <summary>
        /// The Unique Identifier for the entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// DateTime when Object is created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// DateTime when Object is Modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
