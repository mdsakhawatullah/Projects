using MasjidManagementSystem.DB;
using MasjidManagementSystem.Models;
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
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Imam imam)
		{
			_context.Imams.Add(imam);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Update(int id)
		{
			Imam? imam = _context.Imams.ToList().FirstOrDefault(e=> e.Id == id);
			return View(imam);
		}
		[HttpPost]
		public IActionResult Update(Imam imam)
		{
			if(imam.Id>0)
			{
				_context.Imams.Update(imam);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}
		public IActionResult Details(int id)
		{
			var list = _context.Imams.ToList().FirstOrDefault(e => e.Id == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Imams.ToList().FirstOrDefault(e => e.Id == id);
			if (library != null)
			{
				_context.Imams.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
