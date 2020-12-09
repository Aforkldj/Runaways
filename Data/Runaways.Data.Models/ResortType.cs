namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class ResortType : BaseModel<string>
    {
        public ResortType()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Resorts = new HashSet<Resort>();
        }

        // Mountain/Ski, Seaside/Beach, Leisure/Spa
        [Required]
        public string Type { get; set; }

        public virtual ICollection<Resort> Resorts { get; set; }
    }
}
