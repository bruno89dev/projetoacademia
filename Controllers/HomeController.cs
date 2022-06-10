﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoAcademia.Database;
using ProjetoAcademia.Models;

namespace ProjetoAcademia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext database;

        public HomeController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Privacy(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
