using MasjidManagementSystem.DB;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagementSystem.Controllers
{
	public class ImamController : Controller
	{
		private readonly MasjidDbContext _context;
		public ImamController(MasjidDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var listOfImams = _context.Imams.ToList();
			return View(listOfImams);
		}
	}
}
