namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Season : BaseDeletableModel<string>
    {
        public Season()
        {
            this.Id = Guid.NewGuid().ToString();
            this.SeasonPrices = new HashSet<RoomSeasonPrice>();
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public string HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<RoomSeasonPrice> SeasonPrices { get; set; }
    }
}