using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SOCSeafood.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

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
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Newsletters.Where(x => x.User.Id == currentUser.Id));
        }

        public IActionResult List()
        {
            return View(_db.Newsletters.ToList());
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
            DateTime timestamp = DateTime.Now;
            newsletter.SubscribeDate = timestamp;
            newsletter.Email = currentUser.UserName;
            newsletter.IsSignedUp = true;
            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var thisNewsletter = _db.Newsletters.FirstOrDefault(Newsletter => Newsletter.Id == id);
            return View(thisNewsletter);
        }
        public IActionResult Edit(int id)
        {
            var thisNewsletter = _db.Newsletters.FirstOrDefault(Newsletters => Newsletters.Id == id);
            return View(thisNewsletter);
        }

        [HttpPost]
        public IActionResult Edit(Newsletter newsletter)
        {
            _db.Entry(newsletter).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisNewsletter = _db.Newsletters.FirstOrDefault(Newsletters => Newsletters.Id == id);
            return View(thisNewsletter);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisNewsletter = _db.Newsletters.FirstOrDefault(Newsletters => Newsletters.Id == id);
            _db.Newsletters.Remove(thisNewsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
