namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Review : BaseDeletableModel<string>
    {
        public Review()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
        }

        [Range(1, 10)]
        public int Cleanliness { get; set; }

        [Range(1, 10)]
        public int FoodQuality { get; set; }

        [Range(1, 10)]
        public int StaffAttitude { get; set; }

        [Range(1, 10)]
        public int OverallQualityPriceRelevance { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        [Required]
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }

        [Required]
        public string HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
