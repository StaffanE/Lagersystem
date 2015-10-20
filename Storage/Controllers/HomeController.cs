using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

/*
        // Smart sökfunktion med LINQ från Scott Allens Ode to food-exempel.
 
        public ActionResult Index(string searchTerm = null)
        {
            var model =
                _db.Restaurants                                                             //  I restaurants  
                   .OrderByDescending(r => r.Reviews.Average(review => review.Rating))     //   Sortera i fallande ordning på medelbeyget som hämtats från review-klassens Rating-property)
                   .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))        //   filter-villkor:  
                   .Take(10)                                                                //  
                   .Select(r => new RestaurantListViewModel                                //  
                   {
                       Id = r.Id,
                       Name = r.Name,
                       City = r.City,
                       Country = r.Country,
                       CountOfReviews = r.Reviews.Count()
                   }
                            );

            return View(model);
        }

        */

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