using Microsoft.AspNetCore.Mvc;
using System;

namespace Project01MVC.Controllers
{
    public class MoviesController : Controller
    {
        // Action : public Non-Static
        // Movies/GetMovie/10
        public IActionResult GetMovie(int id , string name)
        {
            // return $"Movie with ID: {id}";

            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with ID: {id}";
            //result.ContentType = "text/html";

            return Content($"Movie with ID: {id}" , "text/html"); // helper method
        }

        [ActionName("Index")]
        [HttpGet]
        public IActionResult TestRedirectToAction()
        {
            //RedirectResult redirectResult = new RedirectResult("https://localhost:44395/Movies/GetMovie/10");
            //return Redirect("https://localhost:44395/Movies/GetMovie/10");

            //return RedirectToAction(nameof(GetMovie), new { id = 1 });
            return RedirectToRoute("degault", new { Controller = "Movies", Action = "GetMovie", id = 10 });
        }

        public IActionResult TestModelBinding(int id , string title , Movie movie)
        {
            return View(movie);
        }

        public IActionResult TestCollectionParameter(int[] arr)
        {
            return View(arr);
        }

        public IActionResult TestModelBindingFromRequest([FromBody]Movie movie)
        {
            return View(movie);
        }
    }
}
