using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int MovieId { get; set; }
        public virtual string ReviewTitle { get; set; }
        public virtual string ReviewComment { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual double Rating { get; set; }

        public virtual Person Person { get; set; }
        public virtual Movie Movie { get; set; }

    }
}