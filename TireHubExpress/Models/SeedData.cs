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

                    //Added Product Data Information

                    //Product 1
                    new Tire
                    {
                        Name = "Road Master",
                        Type = "Summer",
                        Material = "Synthetic Rubber",
                        Durability = "Medium",
                        Stock = 150,
                        Price = 74.95M,
                        Review = 4
                    },

                    //Product 2
                    new Tire
                    {
                        Name = "Snow Grip",
                        Type = "Winter",
                        Material = "Blended Rubber",
                        Durability = "Very High",
                        Stock = 300,
                        Price = 109.99M,
                        Review = 5
                    },

                    //Product 3
                    new Tire
                    {
                        Name = "Eco Tread",
                        Type = "All-Season",
                        Material = "Eco-Friendly Rubber",
                        Durability = "High",
                        Stock = 100,
                        Price = 99.50M,
                        Review = 4
                    },

                    //Product 4
                    new Tire
                    {
                        Name = "Off-Road Beast",
                        Type = "Off-Road",
                        Material = "Heavy-Duty Rubber",
                        Durability = "Extreme",
                        Stock = 75,
                        Price = 129.99M,
                        Review = 4
                    },

                    //Product 5
                    new Tire
                    {
                        Name = "SportXtreme",
                        Type = "Performance",
                        Material = "High-Performance Compound",
                        Durability = "Ultra-High",
                        Stock = 75,
                        Price = 149.95M,
                        Review = 5
                    },

                    //Product 6
                    new Tire
                    {
                        Name = "City Slicker",
                        Type = "Urban",
                        Material = "City-Grade Rubber",
                        Durability = "Medium",
                        Stock = 120,
                        Price = 79.99M,
                        Review = 5

                    },

                    //Product 7
                    new Tire
                    {
                        Name = "Rain Guard",
                        Type = "Wet-Weather",
                        Material = "Hydrophobic Rubber",
                        Durability = "High",
                        Stock = 80,
                        Price = 89.50M,
                        Review = 4

                    },

                    //Product 8
                    new Tire
                    {
                        Name = "Classic Cruiser",
                        Type = "Vintage",
                        Material = "Retro-Style Rubber",
                        Durability = "Medium",
                        Stock = 60,
                        Price = 119.99M,
                        Review = 5

                    },

                    //Product 9
                    new Tire
                    {
                        Name = "Eco Grip",
                        Type = "Eco-Friendly",
                        Material = "Recycled Rubber",
                        Durability = "Medium",
                        Stock = 90,
                        Price = 94.99M,
                        Review = 5

                    },

                    //Product 10
                    new Tire
                    {
                        Name = "Snow Master",
                        Type = "Snow",
                        Material = "Snow-Grade Rubber",
                        Durability = "High",
                        Stock = 110,
                        Price = 79.95M,
                        Review = 4

                    },

                    //Product 11
                    new Tire
                    {
                        Name = "Adventure Pro",
                        Type = "All-Terrain",
                        Material = "Toughened Rubber",
                        Durability = "Very High",
                        Stock = 70,
                        Price = 139.99M,
                        Review = 4

                    },

                    //Product 12
                    new Tire
                    {
                        Name = "Speed Demon",
                        Type = "Racing",
                        Material = "Racing Grade",
                        Durability = "Ultra-High",
                        Stock = 40,
                        Price = 169.99M,
                        Review = 5
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
