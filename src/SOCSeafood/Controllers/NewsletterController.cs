using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SOCSeafood.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace SOCSeafood.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly SocDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public NewsletterController(UserManager<ApplicationUser> userManager, SocDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Newsletters.Where(x => x.User.Id == currentUser.Id));
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(Newsletter newsletter)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            newsletter.User = currentUser;
            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
