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
        }
    }
}