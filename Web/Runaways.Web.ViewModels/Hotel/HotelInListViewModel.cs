namespace Runaways.Web.ViewModels.Hotel
{
    using AutoMapper;
    using Runaways.Data.Models;
    using Runaways.Services.Mapping;
    using System.Collections.Generic;

    public class HotelInListViewModel : IMapFrom<Hotel>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Category { get; set; }

        public string Board { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public ICollection<Image> Images { get; set; }


    }
}
