namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Runaways.Data.Models;

    public class BoardsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Boards.Any())
            {
                return;
            }

            var boards = new List<string> { "BO", "BB", "HB", "FB", "AI", "UAI" };

            foreach (var board in boards)
            {
                await dbContext.Boards.AddAsync(new Board { Type = board });
            }
        }
    }
}
