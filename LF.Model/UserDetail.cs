namespace LF.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model to define User Details
    /// </summary>
    public class UserDetail: Entity
    {
        /// <summary>
        /// First Name of the User
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the User
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Street of the User
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// ZipCode of the User
        /// </summary>
        [Required]
        public string ZipCode { get; set; }

        /// <summary>
        /// Users City
        /// </summary>
        [Required]
        [StringLength(255, MinimumLength = 2)]
        public string City { get; set; }

        /// <summary>
        /// License Plate of the Users Car
        /// </summary>
        [Required]
        [StringLength(6)]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Users Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Reference to the User 
        /// </summary>
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
