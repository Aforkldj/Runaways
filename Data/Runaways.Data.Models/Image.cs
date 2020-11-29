namespace Runaways.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Path { get; set; }

        [Required]
        public string DefaultText { get; set; }

        [Required]
        public string ImageTagId { get; set; }
        public virtual ImageTag ImageTag { get; set; }

        // EntityId is set if img is of Entity
        public string ExternalId { get; set; }
    }
}