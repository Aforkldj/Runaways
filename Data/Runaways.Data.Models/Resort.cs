namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Resort : BaseModel<string>
    {
        public Resort()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
            this.Hotels = new HashSet<Hotel>();
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string ResortTypeId { get; set; }
        public ResortType ResortType { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}