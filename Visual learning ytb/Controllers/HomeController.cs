using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Visual_learning_ytb.Data;
using Visual_learning_ytb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Visual_learning_ytb.Controllers
{
    public class HomeController : Controller
    {
		private readonly Visual_learning_ytbContext _context;

		public HomeController(Visual_learning_ytbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View(_context.Product.Include(p => p.Category).ToList()) ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}