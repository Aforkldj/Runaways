namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Hotel : BaseModel<string>
    {
        public Hotel()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Seasons = new HashSet<Season>();
            this.Rooms = new HashSet<Room>();
            this.Reviews = new HashSet<Review>();
            this.Images = new HashSet<Image>();
        }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        // ski slope, beach (m)
        public int? DistanceTo { get; set; }

        public bool? IsPetFriendly { get; set; }

        public bool? HasSpa { get; set; }

        public bool? HasIndoorPool { get; set; }

        public bool? HasOutdoorPool { get; set; }

        [Required]
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public string HotelTypeId { get; set; }
        public virtual HotelType HotelType { get; set; }

        [Required]
        public string BoardId { get; set; }
        public virtual Board Board { get; set; }

        public virtual CheckList CheckList { get; set; }

        public virtual ICollection<Season> Seasons { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
