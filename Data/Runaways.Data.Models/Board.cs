namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Board : BaseModel<string>
    {
        public Board()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Hotels = new HashSet<Hotel>();
        }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}