
using Microsoft.AspNetCore.Mvc;
using Visual_learning_ytb.Data;

namespace Visual_learning_ytb.Models
{
	public class Navbar: ViewComponent
	{
        private readonly Visual_learning_ytbContext _context;

        public Navbar(Visual_learning_ytbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
