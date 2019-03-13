using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Movie
    {
        public virtual int MovieId { get; set; }
        public virtual int DirectorId { get; set; }

        public virtual string Title { get; set; }
        public virtual string Decription { get; set; }
        public virtual string Language { get; set; }
        public virtual int Duration { get; set; }
        public virtual String Genre { get; set; } //Action, Thriller, Comedy
        public virtual string OfficialWebsite { get; set; }
        public virtual string LogoLink { get; set; }
        public virtual string TrailerLink { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        public virtual int Votes { get; set; }
        public virtual double Rating { get; set; }

        public virtual Person Director { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}