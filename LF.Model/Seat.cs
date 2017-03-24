namespace LF.Model
{
    /// <summary>
    /// Model to define Seats
    /// </summary>
    public class Seat : Entity
    {
        /// <summary>
        /// The X Position for the Seat
        /// </summary>
        public int XPosition { get; set; }

        /// <summary>
        /// The Y Position for the Seat
        /// </summary>
        public int YPosition { get; set; }

        /// <summary>
        /// Reference to the user the Seat is assigned to
        /// </summary>
        public int? UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// Reference to the type of the Seat
        /// </summary>
        public int SeatTypeId { get; set; }
        public SeatType SeatType { get; set; }
    }
}

