namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Runaways.Data.Common.Models;

    public class Booking : BaseModel<string>
    {
        public Booking()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Accommodations = new HashSet<Accommodation>();
        }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public double TotalPrice { get; set; }

        [Required]
        public string HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        [Required]
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}
