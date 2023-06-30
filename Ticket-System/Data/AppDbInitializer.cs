using Ticket_System.Data.Enums;
using Ticket_System.Models;

namespace Ticket_System.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                //database will be created if doesn't existed
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://www.cineman.ch/article/gaspar-no%C3%A9-the-man-behind-vortex",
                            Description ="This is the description of the first cinema."
                        },
                          new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://www.cineman.ch/article/top-13-true-crime-netflix-documentaries-stranger-than-fiction",
                            Description ="This is the description of the second cinema."
                        },
                            new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://www.cineman.ch/article/quiet-on-set-podcast-en",
                            Description ="This is the description of the third cinema."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName ="Actor 1",
                            Biography ="This is the biograpy of the first actor",
                            ProfilePicture ="https://medstore.bluecinema.ch/1014_170_cd7ac821cfb9155070b7433c1789f906d30bab47.jpg",
                        },
                        new Actor()
                        {
                            FullName ="Actor 2",
                            Biography ="This is the biograpy of the second actor",
                            ProfilePicture ="https://medstore.bluecinema.ch/1014_170_cd7ac821cfb9155070b7433c1789f906d30bab47.jpg",
                        },
                        new Actor()
                        {
                            FullName ="Actor 3",
                            Biography ="This is the biograpy of the third actor",
                            ProfilePicture ="https://medstore.bluecinema.ch/1014_170_cd7ac821cfb9155070b7433c1789f906d30bab47.jpg",
                        }
                    });
                    context.SaveChanges();
                }
                //Production
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Biography ="This is the biography of the first producer",
                            ProfilePictureUrl ="https://medstore.bluecinema.ch/1017_344_fa35d49f0e7b13fe47bb8a08286ae518d18ac6ae.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Biography ="This is the biography of the second producer",
                            ProfilePictureUrl ="https://medstore.bluecinema.ch/1017_344_fa35d49f0e7b13fe47bb8a08286ae518d18ac6ae.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Biography ="This is the biography of the third producer",
                            ProfilePictureUrl ="https://medstore.bluecinema.ch/1017_344_fa35d49f0e7b13fe47bb8a08286ae518d18ac6ae.jpg",
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description ="This is the discruption of cold soles movie.",
                            Price =23.4,
                            ImageUrl = "https://medstore.bluecinema.ch/1017_432_60965a1fe3819c077892afe027286a6c23926b2b.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategories = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Movie one",
                            Description ="This is the discruption of cold Movie one.",
                            Price =23.4,
                            ImageUrl = "https://medstore.bluecinema.ch/1017_432_60965a1fe3819c077892afe027286a6c23926b2b.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategories = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie two",
                            Description ="This is the discruption of cold Movie two.",
                            Price =23.4,
                            ImageUrl = "https://medstore.bluecinema.ch/1017_432_60965a1fe3819c077892afe027286a6c23926b2b.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategories = MovieCategory.Documentary
                        },
                    });
                    context.SaveChanges();
                }
                //Actor and Movies
                if (!context.ActorMovies.Any())
                {
                    context.ActorMovies.AddRange(new List<ActorMovie>() {
                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId =2
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
