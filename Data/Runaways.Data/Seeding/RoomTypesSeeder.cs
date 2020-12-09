namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Runaways.Data.Models;

    public class RoomTypesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.RoomTypes.Any())
            {
                return;
            }

            var roomTypes = new List<string> { "SGL", "DBL 2+0", "DBL 2+1", "DBL 2+2", "FAM 2+2", "FAM 2+3", "APT 2+2", "APT 2+3", "APT 4+2", "APT 6+0" };

            foreach (var roomType in roomTypes)
            {
                 await dbContext.RoomTypes.AddAsync(new RoomType
                {
                    Type = roomType,
                    RegularBeds = this.GetRegularBeds(roomType),
                    ExtraBeds = this.GetExtraBeds(roomType),
                });
            }
        }

        public int GetRegularBeds(string roomType)
        {
            int regularBeds = 1;
            if (roomType != "SGL")
            {
                regularBeds = int.Parse(roomType.Substring(roomType.Length - 3, 1));
            }

            return regularBeds;
        }

        public int GetExtraBeds(string roomType)
        {
            int extraBeds = 0;
            if (roomType != "SGL")
            {
                extraBeds = int.Parse(roomType[roomType.Length - 1].ToString());
            }

            return extraBeds;
        }
    }
}
