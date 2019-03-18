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
            MovieViewModel movieVM = new MovieViewModel();

            //new movies
            movieVM.NewMovies = db.Movies.Where(m => m.ReleaseDate.Year >= DateTime.Now.Year && m.ReleaseDate.Month <= DateTime.Now.Month).ToList();
            //upcoming movies
            movieVM.UpComingMovies = db.Movies.Where(m => m.ReleaseDate.Year >= DateTime.Now.Year && m.ReleaseDate.Month > DateTime.Now.Month).ToList();
            //top rated movies
            movieVM.TopRatedMovies = db.Movies.OrderByDescending(m => m.Rating).Take(3).ToList();

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

        public ActionResult CreateReview([Bind(Include = "ReviewId,PersonId,MovieId,ReviewTitle,ReviewComment,Created,Rating")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", review.MovieId);
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "Forename", review.PersonId);
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title");
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "Forename");
            return View();
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