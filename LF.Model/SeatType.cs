using System.Collections.Generic;

namespace LF.Model
{
    public class SeatType: Entity
    {
        public string  Name { get; set; }
        public string  BackgroundColor { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string ForeColor { get; set; }
        public string Border { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}
