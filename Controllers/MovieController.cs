using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final.Models;

namespace final.Controllers
{
    public class MovieController:Controller{
        private MovieContext _context;
        public MovieController(MovieContext context){
            _context = context;
        }
       
       [HttpPost]
       public IActionResult AddMovie(MovieViewModel movie)
        {
            System.Console.WriteLine($"You hit the MovieController {movie.Director} * {movie.Length} * {movie.Movie}");
            TryValidateModel(movie);
            if (ModelState.IsValid)
            {
                System.Console.WriteLine("***************&&&$%^^Model is valid.");
                //_context.Add(movie);
                //await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard", "Dashboard");
            } else {
                DashboardViewModel data = new DashboardViewModel(){
                    MovieForm = movie
                };
                return View("../Dashboard/Dashboard", data);
            }
            
        }
   }
}