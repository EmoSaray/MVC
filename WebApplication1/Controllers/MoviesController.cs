using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewsModels;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random( )
        {
            Movie movie = new Movie() { Name = "Алабала" };

            var customers = new List<Customer>()
            {
                new Customer(){ Name = "Мартин "},
                new Customer(){ Name = "Стефан "}
            };

            var viewModel = new RandomMoiveViewModel()
            {
                Movie = movie,
                Customers = customers
            };



            return View(viewModel);
            //return View(movie);
            //return Content("Здраей, Стефан");
            //return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            return Content("БРАВО! ID=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format( "pageIndex={0}&sortBy={1}",pageIndex, sortBy ));
        }
    }
}