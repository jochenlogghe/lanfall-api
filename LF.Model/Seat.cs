namespace LF.Model
{
    public class Seat : Entity
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int SeatTypeId { get; set; }
        public SeatType SeatType { get; set; }
    }
}

