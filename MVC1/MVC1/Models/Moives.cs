using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Moives
    {
        public virtual int MoviesId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime RealseDate { get; set; }
        public virtual string Description { get; set; }
        public virtual Genre Genre { get; set; }

    }
}