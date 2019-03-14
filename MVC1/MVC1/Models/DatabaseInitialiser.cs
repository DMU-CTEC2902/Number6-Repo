﻿using System;
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
            //Users of the site
            Person p1 = new Person
            {
                PersonId = 1,
                Forename = "John",
                Surname = "Smith",
                Username = "jsmith",
                Password = "jsmithPass",
                Role = 1 //User
            };
            context.People.Add(p1);

            Person p2 = new Person
            {
                PersonId = 2,
                Forename = "Mark",
                Surname = "Rally",
                Username = "mrally",
                Password = "mrallyPass",
                Role = 1 //User
            };
            context.People.Add(p2);

            Person p3 = new Person
            {
                PersonId = 3,
                Forename = "Dave",
                Surname = "Smith",
                Username = "dsmith",
                Password = "dsmithPass",
                Role = 1 //User
            };
            context.People.Add(p3);

            Person p4 = new Person
            {
                PersonId = 4,
                Forename = "Jordan",
                Surname = "Smith",
                Username = "jsmith",
                Password = "jsmithPass",
                Role = 1 //User
            };
            context.People.Add(p4);
           
            Person p5 = new Person
            {
                PersonId = 5,
                Forename = "Peter",
                Surname = "Hedges",
                Role = 2 //Director
            };
            context.People.Add(p5);

            Person p6 = new Person
            {
                PersonId = 6,
                Forename = "Francis",
                Surname = "Ford Coppola",
                Role = 2 //Director
            };
            context.People.Add(p6);

            Person p7 = new Person
            {
                PersonId = 7,
                Forename = "Jon",
                Surname = "Watts",
                Role = 2 //Director
            };
            context.People.Add(p7);

            Person p8 = new Person
            {
                PersonId = 8,
                Forename = "Jon",
                Surname = "Favreau",

                Role = 2 //Director
            };
            context.People.Add(p8);
            
            Person p9 = new Person
            {
                PersonId = 9,
                Forename = "Smith",
                Surname = "Fort",

                Role = 3 //Actor
            };
            context.People.Add(p9);

            //Movies
            Movie m1 = new Movie
            {
                MovieId = 1,
                Title = "Ben Is Back",
                Description = "A drug addicted teenage boy shows up unexpectedly at his family's home on Christmas Eve.",
                ReleaseDate = new DateTime(2019, 03, 15),

                DirectorId = 5,
                Director = p5,

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

                DirectorId = 6,
                Director = p6,

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

                DirectorId = 7,
                Director = p7,

                OfficialWebsite = "https://www.marvel.com/movies/spider-man-far-from-home",
                TrailerLink = "https://www.imdb.com/videoplayer/vi3860314649?playlistId=tt6320628&ref_=tt_ov_vi",
                LogoLink = "https://m.media-amazon.com/images/M/MV5BMjE1MzE5MjczMl5BMl5BanBnXkFtZTgwOTgwMTgxNzM@._V1_UX182_CR0,0,182,268_AL_.jpg",

                Language = "English",
               
                Rating = 0
            };
            context.Movies.Add(m3);

            Movie m4 = new Movie
            {
                MovieId = 3,
                Title = "The Lion King",
                Description = "CGI re-imagining of the 1994 Disney classic.",
                ReleaseDate = new DateTime(2019, 07, 19),

                DirectorId = 8,
                Director = p8,

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

                DirectorId = 8,
                Director = p8,

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
                PersonId = 1,
                Person = p1,
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
                PersonId = 2,
                Person = p2,
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
                PersonId = 2,
                Person = p2,
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
                PersonId = 3,
                Person = p3,
                Created = new DateTime(2019, 02, 17),
                ReviewTitle = "What a boring movie",
                ReviewComment = "waste of time.",
                Rating = 2
                
            };
            context.Reviews.Add(r3);

            Review r4 = new Review
            {
                ReviewId = 4,
                MovieId = 5,
                Movie = m5,
                PersonId = 4,
                Person = p4,
                Created = new DateTime(2019, 01, 21),
                ReviewTitle = "What a boring movie",
                ReviewComment = "waste of time.",
                Rating = 10
            };
            context.Reviews.Add(r3);

            base.Seed(context);
        }
    }
}