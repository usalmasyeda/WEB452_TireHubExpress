using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TireHubExpress.Data;
using System;
using System.Linq;

namespace TireHubExpress.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TireHubExpressContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TireHubExpressContext>>()))
            {
                // Look for any movies.
                if (context.Tire.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tire.AddRange(
                    new Tire
                    {
                        Name = "When Harry Met Sally",
                        Type = 
                        Material = "Romantic Comedy",
                        Durability = 
                        Stock = 
                        Price = 25.99M
                        Review = 
                    },

                    new Tire
                    {
                        
                    },

                    new Tire
                    {
                        
                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    },

                    new Tire
                    {

                    }

                );
                context.SaveChanges();
            }
        }
    }
}
