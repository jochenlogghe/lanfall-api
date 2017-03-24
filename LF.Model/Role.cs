namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define a Role
    /// </summary>
    public class Role: Entity
    {
        /// <summary>
        /// The Name of the Role
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The Users who have this Role
        /// </summary>
        public ICollection<User> Users { get; set; }
    }
}
