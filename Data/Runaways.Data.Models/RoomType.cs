namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class RoomType : BaseModel<string>
    {
        public RoomType()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Rooms = new HashSet<Room>();
        }

        // SGL, DBL, APT
        [Required]
        public string Type { get; set; }

        public int? RegularBeds { get; set; }

        public int? ExtraBeds { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}