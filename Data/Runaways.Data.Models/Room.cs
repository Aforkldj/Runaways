namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Runaways.Data.Common.Models;

    public class Room : BaseModel<string>
    {
        public Room()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
            this.SeasonPrices = new HashSet<RoomSeasonPrice>();
        }

        [Required]
        public string HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        [Required]
        public string RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        [Required]
        public string RoomNameId { get; set; }
        public virtual RoomName RoomName { get; set; }

        public int? Allotment { get; set; }

        public int? MinGuests { get; set; }

        public int? MaxGuests { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<RoomSeasonPrice> SeasonPrices { get; set; }
    }
}
