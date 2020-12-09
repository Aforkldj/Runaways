namespace Runaways.Web.ViewModels.SearchResults
{
    using System;

    public class SearchByResortInputModel
    {
        public string ResortName { get; set; }

        public string HotelName { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int GuestCount { get; set; }

        public int RoomCount { get; set; }
    }
}
