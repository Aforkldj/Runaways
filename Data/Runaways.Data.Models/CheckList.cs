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

        public int HasBigRooms { get; set; }

        public int IsSparklingClean { get; set; }

        public int HasGreatChoiceBuffet { get; set; }

        public int HasIntimateAtmosphere { get; set; }

        public int HasRoomsWithGreatView { get; set; }

        public int IsStaffVeryAttentive { get; set; }

        [Required]
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }

        [Required]
        public string HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
