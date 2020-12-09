namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Runaways.Data.Models;

    public class ResortsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Resorts.Any())
            {
                return;
            }

            var resorts = new List<string>
            {
                "Kavarna", "Balchik", "Albena", "Kranevo", "Golden Sands", "St.Constantine & Elena",
                "Sunny Day", "Byala", "Obzor", "Sunny Beach", "Nessebar", "Pomorie", "Primorsko", "Sozopol",
            };

            var resortTypeId = dbContext.ResortTypes.Where(x => x.Type == "Seaside/ Beach").Select(x => x.Id).FirstOrDefault();

            foreach (var resort in resorts)
            {
                await dbContext.Resorts.AddAsync(new Resort { Name = resort, ResortTypeId = resortTypeId });
            }
        }
    }
}
