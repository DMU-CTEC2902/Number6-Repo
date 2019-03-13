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
            Person p1 = new Person();
            p1.PersonId = 1;
            p1.Forename = "John";
            p1.Surname = "Smith";
            p1.Role = 1; //User
            context.People.Add(p1);

            Person p2 = new Person();
            p2.PersonId = 2;
            p2.Forename = "Mark";
            p2.Surname = "Rally";
            p2.Role = 1; //User
            context.People.Add(p2);

            //People that are Directors
            Person d1 = new Person();
            d1.PersonId = 3;
            d1.Forename = "Peter";
            d1.Surname = "Hedges";
            d1.Role = 2; //Director
            context.People.Add(d1);

            Person d2 = new Person();
            d2.PersonId = 4;
            d2.Forename = "Francis";
            d2.Surname = "Ford Coppola";
            d2.Role = 2; //Director
            context.People.Add(d2);

            Person d3 = new Person();
            d3.PersonId = 5;
            d3.Forename = "Jon";
            d3.Surname = "Watts";
            d3.Role = 2; //Director
            context.People.Add(d3);

            Person d4 = new Person();
            d4.PersonId = 6;
            d4.Forename = "Jon";
            d4.Surname = "Favreau";
            d4.Role = 2; //Director
            context.People.Add(d4);

            //Website users
            User u1 = new User();
            u1.UserId = 1;
            u1.PersonId = 1;
            u1.Username = "jsmith";
            u1.Password = "jsmithPass";
            u1.Person = p1;
            context.Users.Add(u1);

            User u2 = new User();
            u2.UserId = 2;
            u2.PersonId = 2;
            u2.Username = "mrally";
            u2.Password = "mrallyPass";
            u2.Person = p2;
            context.Users.Add(u2);


            //Movies
            Movie m1 = new Movie();
            m1.MovieId = 1;
            m1.Title = "Ben Is Back";
            m1.Decription = "A drug addicted teenage boy shows up unexpectedly at his family's home on Christmas Eve.";
            m1.ReleaseDate = new DateTime(2019, 03, 15);

            m1.DirectorId = 3;
            m1.Director = d1;

            m1.OfficialWebsite = "https://blackbearpictures.com/films-in-theaters/ben-is-back/";
            m1.TrailerLink = "https://www.youtube.com/embed/MI9NdYktzfE";
            m1.LogoLink = "https://m.media-amazon.com/images/M/MV5BZGY3ZWMyYjEtMDMzYi00NDQyLWE1MWEtMDNmMjRlOGVkNDc3XkEyXkFqcGdeQXVyODAzODU1NDQ@._V1_UX182_CR0,0,182,268_AL_.jpg";

            m1.Language = "English";
            m1.Duration = 103;
            m1.Votes = 51;
            m1.Rating = 7.8;
            context.Movies.Add(m1);

            Movie m2 = new Movie();
            m2.MovieId = 2;
            m2.Title = "The Godfather";
            m2.Decription = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
            m2.ReleaseDate = new DateTime(1972, 08, 24);

            m2.DirectorId = 4;
            m2.Director = d2;

            m2.OfficialWebsite = "https://www.facebook.com/thegodfather";
            m2.TrailerLink = "https://www.imdb.com/videoplayer/vi1348706585?playlistId=tt0068646&ref_=tt_ov_vi";
            m2.LogoLink = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg";

            m2.Language = "English";
            m2.Duration = 175;
            m2.Votes = 25005;
            m2.Rating = 9.6;
            context.Movies.Add(m2);

            Movie m3 = new Movie();
            m3.MovieId = 3;
            m3.Title = "Spider-Man: Far From Home";
            m3.Decription = "Peter Parker and his friends go on summer vacation to Europe, where Peter finds himself trying to fight off a new foe, Mysterio, who as his name indicates may not be all that he appears.";
            m3.ReleaseDate = new DateTime(2019, 07, 05);

            m3.DirectorId = 5;
            m3.Director = d3;

            m3.OfficialWebsite = "https://www.marvel.com/movies/spider-man-far-from-home";
            m3.TrailerLink = "https://www.imdb.com/videoplayer/vi3860314649?playlistId=tt6320628&ref_=tt_ov_vi";
            m3.LogoLink = "https://m.media-amazon.com/images/M/MV5BMjE1MzE5MjczMl5BMl5BanBnXkFtZTgwOTgwMTgxNzM@._V1_UX182_CR0,0,182,268_AL_.jpg";

            m3.Language = "English";
            //m3.Duration = 0;
            m3.Votes = 0;
            m3.Rating = 0;
            context.Movies.Add(m3);

            Movie m4 = new Movie();
            m4.MovieId = 3;
            m4.Title = "The Lion King";
            m4.Decription = "CGI re-imagining of the 1994 Disney classic.";
            m4.ReleaseDate = new DateTime(2019, 07, 19);

            m4.DirectorId = 6;
            m4.Director = d4;

            m4.OfficialWebsite = "https://disney.co.uk/";
            m4.TrailerLink = "https://www.imdb.com/videoplayer/vi2773858841?playlistId=tt6105098&ref_=tt_ov_vi";
            m4.LogoLink = "https://m.media-amazon.com/images/M/MV5BMjIwMjE1Nzc4NV5BMl5BanBnXkFtZTgwNDg4OTA1NzM@._V1_UX182_CR0,0,182,268_AL_.jpg";

            m4.Language = "English";
            //m2.Duration = 0;
            m4.Votes = 0;
            m4.Rating = 0;
            context.Movies.Add(m4);

            //Reviews
            Review r1 = new Review();
            r1.ReviewId = 1;
            r1.MovieId = 1;
            r1.Movie = m1;
            r1.UserId = 1;
            r1.User = u1;
            r1.Created = new DateTime(2019, 03, 15);
            r1.ReviewTitle = "Julia Roberts on top of her game";
            r1.ReviewComment = "Ben Is Back follows a story of a young addict returning home for holidays by putting the lives of his family members and those who he had affected as an addict dramatically changes within 24 hours. A triumphal performance of Julia Roberts as the mother, who is fighting for salvation of her child, is probably one of the best of her career. Lucas Hedges, who plays Ben, also son of the director Peter Hedges, is on a phenomenal rise, appearing in not one but two Oscar-worthy performances this year, proving that Hollywood can still hold on the line with decent young actors such as Hedges as old talents slowly fade out. A passionate project that is ambitious, raw and tender, centered on the redemption addicts can get from their family.";
            r1.Rating = 8;
            r1.Votes = 10;
            context.Reviews.Add(r1);

            Review r2 = new Review();
            r2.ReviewId = 2;
            r2.MovieId = 1;
            r2.Movie = m1;
            r2.UserId = 2;
            r2.User = u2;
            r2.Created = new DateTime(2019, 03, 17);
            r2.ReviewTitle = "What a crappy movie";
            r2.ReviewComment = "It litterally does not make sense, waste of time.";
            r2.Rating = 1;
            r2.Votes = 10001;
            context.Reviews.Add(r2);

            base.Seed(context);
        }
    }
}