namespace Runaways.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Runaways.Data.Models;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            Dictionary<string, ApplicationUser> usersWithPass = new Dictionary<string, ApplicationUser>()
            {
                {
                    "client123", new ApplicationUser
                    {
                        UserName = "client123",
                        Email = "client123@abv.bg",
                        EmailConfirmed = true,
                    }
                },
                {
                    "client321", new ApplicationUser
                    {
                        UserName = "client321",
                        Email = "client321@abv.bg",
                        EmailConfirmed = true,
                    }
                },
            };

            foreach (var kvp in usersWithPass)
            {
                var user = kvp.Value;
                var userPass = kvp.Key;

                var exists = await userManager.FindByEmailAsync(user.Email);
                if (exists == null)
                {
                    var result = await userManager.CreateAsync(user, userPass);
                    if (!result.Succeeded)
                    {
                        throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                    }

                    if (!await roleManager.RoleExistsAsync("Client"))
                    {
                        result = await roleManager.CreateAsync(new ApplicationRole("Client"));
                        if (!result.Succeeded)
                        {
                            throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                        }
                    }

                    var userInRole = await userManager.IsInRoleAsync(user, "Client");
                    if (!userInRole)
                    {
                        result = await userManager.AddToRoleAsync(user, "Client");
                        if (!result.Succeeded)
                        {
                            throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                        }
                    }
                }
            }
        }
    }
}
