using System;
using System.Linq;
using GamesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace GamesApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesContext(
                serviceProvider.GetRequiredService<DbContextOptions<GamesContext>>()))
            {
                
                if (context.Games.Any() != true)
                {
                    context.Games.AddRange(
                        new Games
                        {
                            Title = "GTA V",
                            DevStudio = "RockStar"
                        },


                        new Games
                        {
                            Title = "Cyberpunk 2077",
                            DevStudio = "CDPR"

                        },
                        
                        new Games
                        {
                            Title = "UNCHARTED: Legacy of Thieves Collection",
                            DevStudio = "Naughty Dog LLC"

                        },
                        new Games
                        {
                            Title = "The Sims 4",
                            DevStudio = "Electronic Arts"

                        }
                    );
                    context.SaveChanges();
                }
                if (context.Genres.Any() != true)
                {
                    context.Genres.AddRange(
                        new Genres
                        {
                            GenreName = "Action"
                        },
                        
                        new Genres
                        {
                            GenreName = "Adventure"
                        },
                        
                        new Genres
                        {
                            GenreName = "RPG"
                        },
                        
                        new Genres
                        {
                            GenreName = "Open world"
                        }
                    );
                    context.SaveChanges();
                }
                
                
                
            }
        }
    }
}