
using Microsoft.AspNetCore.Mvc;
using Visual_learning_ytb.Data;

namespace Visual_learning_ytb.Models
{
	public class Sidebar : ViewComponent
	{
		private readonly Visual_learning_ytbContext _context;

		public Sidebar(Visual_learning_ytbContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
