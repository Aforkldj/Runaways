namespace Runaways.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Runaways.Data.Common.Models;

    public class RoomSeasonPrice : BaseDeletableModel<string>
    {
        public RoomSeasonPrice()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string SeasonId { get; set; }
        public virtual Season Season { get; set; }

        [Required]
        public string RoomId { get; set; }
        public virtual Room Room { get; set; }

        public double Price { get; set; }
    }
}
