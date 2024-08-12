using Loginwithsession.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Loginwithsession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
           
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login l)
        {
            if (ModelState.IsValid) 
            {
                var data = db.Logins.Where(x => x.Email == l.Email && x.Password == l.Password).FirstOrDefault();
                if (data != null)
                {
                    HttpContext.Session.SetString("UserSession",data.Email);
                    TempData["message"] = "Login Sucessfully";
                    return RedirectToAction("Dashboard", "Home");
                }
                else 
                {
                    ViewBag.mesage1 = "Something went wrong";
                }
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.mysession = HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null);
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Index");
            }
            
        }

    }
}
