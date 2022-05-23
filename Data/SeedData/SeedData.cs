using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCPrimerEjemplo.Data;
using System;
using System.Linq;

namespace MVCPrimerEjemplo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCPrimerEjemploContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCPrimerEjemploContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );

                if (context.Cinema.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cinema.AddRange(
                    new Cinema
                    {
                        Name = "Primer cine",
                        NumberOfRooms = 2,
                        Price = 7.99M
                    },
                    new Cinema
                    {
                        Name = "Segundo cine",
                        NumberOfRooms = 4,
                        Price = 7.99M
                    },
                    new Cinema
                    {
                        Name = "tercer cine",
                        NumberOfRooms = 43,
                        Price = 6
                    }
                );

                context.SaveChanges();
            }
        }
    }
}