namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Runaways.Data.Models;

    public class ResortTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.HotelTypes.Any())
            {
                return;
            }

            var hotelTypes = new List<string> { "Mountain/ Ski", "Seaside/ Beach", "Leisure/ Spa" };

            foreach (var type in hotelTypes)
            {
                await dbContext.HotelTypes.AddAsync(new HotelType { Type = type });
            }
        }
    }
}
