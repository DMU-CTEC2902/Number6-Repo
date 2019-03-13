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

        public virtual int Role { get; set; }

        public string Fullname
        {
            get
            {
                return Forename + " " + Surname;
            }
        }
    }
}