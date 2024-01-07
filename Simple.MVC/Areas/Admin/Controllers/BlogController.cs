using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple.Core.Models;
using Simple.DAL.DAL;

namespace Simple.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blog = _context.Blogs.ToList();
            return View(blog);
        }

        public async Task<IActionResult> CreateAsync()
        {

            return View();
        }

        public async Task<IActionResult> UpdateAsync()
        {

            return View();
        }

        public IActionResult Delete()
        {

            return View();
        }
    }
}
