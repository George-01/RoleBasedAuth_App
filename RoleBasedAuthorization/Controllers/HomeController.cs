using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleBasedAuthorization.Models;

namespace RoleBasedAuthorization.Controllers
{
    public class HomeController : Controller
    {
        //MyDbContext db = new MyDbContext();
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }

            return View();
        }


    }
}