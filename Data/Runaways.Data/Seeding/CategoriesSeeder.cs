namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Runaways.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<string> { "1*", "2*", "2*+", "3*", "3*+", "4*", "5*" };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category { Stars = category });
            }
        }
    }
}
