using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual int PersonId { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }

        public virtual Person Person { get; set; }
        
        //shows all the reviews the user has created on each film 
        public virtual List<Review> Reviews { get; set; }
    }
}