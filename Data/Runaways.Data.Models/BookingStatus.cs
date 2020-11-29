namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class BookingStatus : BaseModel<string>
    {
        public BookingStatus()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Accommodations = new HashSet<Accommodation>();
        }

        // CONFIRMED, WAITING, NOT CONFIRMED, CANCELLED
        [Required]
        public string Status { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}
