namespace Runaways.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Runaways.Data.Common.Models;

    public class CheckList : BaseModel<string>
    {
        public CheckList()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public bool? HasBigRooms { get; set; }

        public bool? IsSparklingClean { get; set; }

        public bool? HasGreatChoiceBuffet { get; set; }

        public bool? HasIntimateAtmosphere { get; set; }

        public bool? HasRoomsWithGreatView { get; set; }

        public bool? IsStaffVeryAttentive { get; set; }

        [Required]
        public string ReviewId { get; set; }
        public virtual Review Review { get; set; }
    }
}
