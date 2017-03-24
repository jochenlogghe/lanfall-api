namespace LF.Model
{
    /// <summary>
    /// The Intersect Model for Competitions and Admins
    /// </summary>
    public class CompetitionAdmin: Entity
    {
        /// <summary>
        /// Indicates if a Admin is the Main Admin
        /// </summary>
        public bool IsMain { get; set; }

        /// <summary>
        /// Reference to the User who is Competition Admin
        /// </summary>
        public int UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// Reference to the Competition 
        /// </summary>
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

    }
}
