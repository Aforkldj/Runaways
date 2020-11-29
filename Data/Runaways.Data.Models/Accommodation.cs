namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Accommodation : BaseModel<string>
    {
        public Accommodation()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Guests = new HashSet<Guest>();
        }
        
        [Required]
        public string RoomId { get; set; }
        public virtual Room Room { get; set; }

        [Required]
        public string BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        [Required]
        public string BookingStatusId { get; set; }
        public virtual BookingStatus BookingStatus { get; set; }

        public int GuestCount { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }
    }
}
