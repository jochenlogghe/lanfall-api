namespace LF.Model
{
    public class CompetitionAdmin: Entity
    {
        public bool IsMain { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

    }
}
