namespace LF.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define Seat Types
    /// </summary>
    public class SeatType: Entity
    {
        /// <summary>
        /// Name of the Seat Type
        /// </summary>
        [Required]
        public string  Name { get; set; }

        /// <summary>
        /// Background Color of the Seat Type
        /// </summary>
        public string  BackgroundColor { get; set; }

        /// <summary>
        /// Background Image Url of the Seat Type
        /// </summary>
        public string BackgroundImageUrl { get; set; }

        /// <summary>
        /// The Font Color for the Seat Type
        /// </summary>
        public string ForeColor { get; set; }

        /// <summary>
        /// Border of the Seat Type Seats
        /// </summary>
        public string Border { get; set; }

        /// <summary>
        /// The Collection of Seats with this Seat Type
        /// </summary>
        public ICollection<Seat> Seats { get; set; }
    }
}
