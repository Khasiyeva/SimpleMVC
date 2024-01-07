using Microsoft.AspNetCore.Mvc;
using Simple.DAL.DAL;

namespace Simple.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
