using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final.Models;

namespace final.Controllers
{
    public class DashboardController:Controller{
        private MovieContext _context;
        public DashboardController(MovieContext context){
            _context = context;
        }
        public IActionResult Dashboard(){
            DashboardViewModel data= new DashboardViewModel(){
                MovieForm= new MovieViewModel()
            };
            return View(data);
        }
    }
}