namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Runaways.Data.Common.Models;

    public class ImageTag : BaseModel<string>
    {
        public ImageTag()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
        }

        [Required]
        public string Tag { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
