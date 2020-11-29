namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Runaways.Data.Common.Models;

    public class HotelType : BaseModel<string>
    {
        public HotelType()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Hotels = new HashSet<Hotel>();
        }

        // Spa Hotel, Family Hotel, Hotel Resort
        [Required]
        public string Type { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}