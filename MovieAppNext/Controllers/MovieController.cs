using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAppNext.Models;

namespace MovieAppNext.Controllers
{
    public class MovieController : Controller
    {

        public Movie Movie { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult MovieResult(Movie movie)
        {
            Movie = movie;
            return View(Movie);
        }
    }
}
