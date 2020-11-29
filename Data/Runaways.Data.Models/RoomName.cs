namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class RoomName : BaseModel<string>
    {
        public RoomName()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Rooms = new HashSet<Room>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
