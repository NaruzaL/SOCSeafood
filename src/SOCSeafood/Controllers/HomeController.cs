using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOCSeafood.Models;
using Microsoft.AspNetCore.Identity;
using SOCSeafood.ViewModels;

namespace SOCSeafood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Review()
        {
            return View();
        }
    }
}
