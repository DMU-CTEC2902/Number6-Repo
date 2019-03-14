using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Person
    {
        public virtual int PersonId { get; set; }        
        public virtual string Forename { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int Role { get; set; }
        

        public string Fullname
        {
            get
            {
                return Forename + " " + Surname;
            }
        }
    
       //shows all the reviews the user has created on each film 
        public virtual List<Review> Reviews { get; set; }
        
        // shows the movies of all the Directos has made 
        public virtual List<Movie> Movies { get; set; }
       
    }
}