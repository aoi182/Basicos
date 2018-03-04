using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie {Id = 1, Name = "Shrek!"};
            return View(movie);
        }
    }
}