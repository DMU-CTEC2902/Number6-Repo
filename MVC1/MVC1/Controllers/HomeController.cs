using MVC1.Models;
using MVC1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db=new DatabaseContext();
        public ActionResult Index()
        {
            //With ViewBag works, but it starts to gets complex when we have more lists
            //ViewBag.Title = "Movies";
            //ViewBag.Movies = db.Movies.ToList();

            //Using viewModel is more organised and from the view we can access those objects very easy like in the code page here
            MovieViewModel movieVM = new MovieViewModel
            {

                //new movies
                NewMovies = db.Movies.Where(m => m.ReleaseDate.Year >= DateTime.Now.Year && m.ReleaseDate.Month <= DateTime.Now.Month).ToList(),
                //upcoming movies
                UpComingMovies = db.Movies.Where(m => m.ReleaseDate.Year >= DateTime.Now.Year && m.ReleaseDate.Month > DateTime.Now.Month).ToList(),
                //top rated movies
                TopRatedMovies = db.Movies.OrderByDescending(m => m.Rating).Take(3).ToList()
            };

            return View(movieVM);
        }

        // GET: Movies/Details/5
        public ActionResult MovieDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        
        //GET: User/Details
        public ActionResult PersonDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person p = db.People.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }

        //GET: User/Details
        public ActionResult DirectorDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person p = db.People.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }


        // GET: Reviews/Create -- this is called first time on load
        public ActionResult AddReview(int? id)
        {            
            //ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title");            //this not needed, as the list of moviews is removed
            ViewBag.Movie = db.Movies.FirstOrDefault(i => i.MovieId == id); // Find the movie, and store the movie in the bag to use it in the ViewPAge.
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "Forename");
            return View();
        }

        // POST: Reviews/Create - this actualy does the save
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddReview(int? id,[Bind(Include = "ReviewId,PersonId,MovieId,ReviewTitle,ReviewComment,Created,Rating")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.MovieId = id.Value; //the moview being reviewd
                review.Created = DateTime.Now; //the date of the review is by default todays date.
                db.Reviews.Add(review);
                db.SaveChanges(); //save

                return RedirectToAction("MovieDetails/"+review.MovieId); //redirect back to the moview.
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", review.MovieId);
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "Forename", review.PersonId);
            return View(review);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}