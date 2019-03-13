using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class DatabaseInitialiser : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //Pople that use the website
            Person p1 = new Person
            {
                PersonId = 1,
                Forename = "John",
                Surname = "Smith",
                Role = 1 //User
            };
            context.People.Add(p1);

            Person p2 = new Person
            {
                PersonId = 2,
                Forename = "Mark",
                Surname = "Rally",
                Role = 1 //User
            };
            context.People.Add(p2);

            Person p3 = new Person
            {
                PersonId = 3,
                Forename = "Dave",
                Surname = "Smith",
                Role = 1 //User
            };
            context.People.Add(p3);

            //People that are Directors
            Person d1 = new Person
            {
                PersonId = 3,
                Forename = "Peter",
                Surname = "Hedges",
                Role = 2 //Director
            };
            context.People.Add(d1);

            Person d2 = new Person
            {
                PersonId = 4,
                Forename = "Francis",
                Surname = "Ford Coppola",
                Role = 2 //Director
            };
            context.People.Add(d2);

            Person d3 = new Person
            {
                PersonId = 5,
                Forename = "Jon",
                Surname = "Watts",
                Role = 2 //Director
            };
            context.People.Add(d3);

            Person d4 = new Person
            {
                PersonId = 6,
                Forename = "Jon",
                Surname = "Favreau",
                Role = 2 //Director
            };
            context.People.Add(d4);

            //Website users
            User u1 = new User
            {
                UserId = 1,
                PersonId = 1,
                Username = "jsmith",
                Password = "jsmithPass",
                Person = p1
            };
            context.Users.Add(u1);

            User u2 = new User
            {
                UserId = 2,
                PersonId = 2,
                Username = "mrally",
                Password = "mrallyPass",
                Person = p2
            };
            context.Users.Add(u2);

            User u3 = new User
            {
                UserId = 3,
                PersonId = 7,
                Username = "dsmith",
                Password = "dsmithPass",
                Person = p3
            };
            context.Users.Add(u3);


            //Movies
            Movie m1 = new Movie
            {
                MovieId = 1,
                Title = "Ben Is Back",
                Description = "A drug addicted teenage boy shows up unexpectedly at his family's home on Christmas Eve.",
                ReleaseDate = new DateTime(2019, 03, 15),

                DirectorId = 3,
                Director = d1,

                OfficialWebsite = "https://blackbearpictures.com/films-in-theaters/ben-is-back/",
                TrailerLink = "https://www.youtube.com/embed/MI9NdYktzfE",
                LogoLink = "https://m.media-amazon.com/images/M/MV5BZGY3ZWMyYjEtMDMzYi00NDQyLWE1MWEtMDNmMjRlOGVkNDc3XkEyXkFqcGdeQXVyODAzODU1NDQ@._V1_UX182_CR0,0,182,268_AL_.jpg",

                Language = "English",
                Duration = 103,
                Rating = 7.8
            };
            context.Movies.Add(m1);

            Movie m2 = new Movie
            {
                MovieId = 2,
                Title = "The Godfather",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                ReleaseDate = new DateTime(1972, 08, 24),

                DirectorId = 4,
                Director = d2,

                OfficialWebsite = "https://www.facebook.com/thegodfather",
                TrailerLink = "https://www.imdb.com/videoplayer/vi1348706585?playlistId=tt0068646&ref_=tt_ov_vi",
                LogoLink = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg",

                Language = "English",
                Duration = 175,
                Rating = 9.6
            };
            context.Movies.Add(m2);

            Movie m3 = new Movie
            {
                MovieId = 3,
                Title = "Spider-Man: Far From Home",
                Description = "Peter Parker and his friends go on summer vacation to Europe, where Peter finds himself trying to fight off a new fow, Mysterio, who as his name indicates may not be all that he appears.",
                ReleaseDate = new DateTime(2019, 07, 05),

                DirectorId = 5,
                Director = d3,

                OfficialWebsite = "https://www.marvel.com/movies/spider-man-far-from-home",
                TrailerLink = "https://www.imdb.com/videoplayer/vi3860314649?playlistId=tt6320628&ref_=tt_ov_vi",
                LogoLink = "https://m.media-amazon.com/images/M/MV5BMjE1MzE5MjczMl5BMl5BanBnXkFtZTgwOTgwMTgxNzM@._V1_UX182_CR0,0,182,268_AL_.jpg",

                Language = "English",
                //m3.Duration = 0;
                Rating = 0
            };
            context.Movies.Add(m3);

            Movie m4 = new Movie
            {
                MovieId = 3,
                Title = "The Lion King",
                Description = "CGI re-imagining of the 1994 Disney classic.",
                ReleaseDate = new DateTime(2019, 07, 19),

                DirectorId = 6,
                Director = d4,

                OfficialWebsite = "https://disney.co.uk/",
                TrailerLink = "https://www.imdb.com/videoplayer/vi2773858841?playlistId=tt6105098&ref_=tt_ov_vi",
                LogoLink = "https://m.media-amazon.com/images/M/MV5BMjIwMjE1Nzc4NV5BMl5BanBnXkFtZTgwNDg4OTA1NzM@._V1_UX182_CR0,0,182,268_AL_.jpg",

                Language = "English",
                Rating = 0
            };
            context.Movies.Add(m4);

            Movie m5 = new Movie
            {
                MovieId = 4,
                Title = "Taken",
                Description = "Liam Nelson is on a mission",
                ReleaseDate = new DateTime(2009, 01, 01),

                DirectorId = 6,
                Director = d4,

                OfficialWebsite = "https://en.wikipedia.org/wiki/Taken_(film)",
                TrailerLink = "https://www.youtube.com/watch?v=uPJVJBm9TPA",
                LogoLink = "http://www.gstatic.com/tv/thumb/v22vodart/177089/p177089_v_v8_at.jpg",

                Language = "English",
                Rating = 10

            };
            context.Movies.Add(m5);
            
            
            
            
            //Reviews
            Review r1 = new Review
            {
                ReviewId = 1,
                MovieId = 1,
                Movie = m1,
                UserId = 1,
                User = u1,
                Created = new DateTime(2019, 03, 15),
                ReviewTitle = "Julia Roberts on top of her game",
                ReviewComment = "Top movie",
                Rating = 8
                
            };
            context.Reviews.Add(r1);

            Review r2 = new Review
            {
                ReviewId = 2,
                MovieId = 1,
                Movie = m1,
                UserId = 2,
                User = u2,
                Created = new DateTime(2019, 03, 17),
                ReviewTitle = "What a crappy movie",
                ReviewComment = "It litterally does not make sense, waste of time.",
                Rating = 1
               
            };
            context.Reviews.Add(r2);

            Review r22 = new Review
            {
                ReviewId = 2,
                MovieId = 2,
                Movie = m2,
                UserId = 2,
                User = u2,
                Created = new DateTime(2019, 03, 17),
                ReviewTitle = "What a crappy movie 2",
                ReviewComment = "It litterally does not make sense, waste of time. 2",
                Rating = 1
               
            };
            context.Reviews.Add(r22);


            Review r3 = new Review
            {
                ReviewId = 3,
                MovieId = 1,
                Movie = m1,
                UserId = 3,
                User = u3,
                Created = new DateTime(2019, 02, 17),
                ReviewTitle = "What a boring movie",
                ReviewComment = "waste of time.",
                Rating = 2
                
            };
            context.Reviews.Add(r3);

            base.Seed(context);
        }
    }
}