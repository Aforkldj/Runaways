namespace Runaways.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class Category : BaseModel<string>
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Hotels = new HashSet<Hotel>();
        }

        public int Stars { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
    }
}