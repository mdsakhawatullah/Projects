using MasjidManagementSystem.DB;
using MasjidManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagementSystem.Controllers
{
	public class VolunteerController : Controller
	{
		private readonly MasjidDbContext _context;
		public VolunteerController(MasjidDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var list = _context.Volunteers.ToList();
			return View(list);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Volunteer vln)
		{
			_context.Volunteers.Add(vln);
			_context.SaveChanges();
			return RedirectToAction("Index");	
		}
		public IActionResult Update(int id)
		{
			Volunteer? vln = _context.Volunteers.ToList().FirstOrDefault(e=>e.Id==id);
			return View(vln);
		}
		[HttpPost]
		public IActionResult Update(Volunteer vln)
		{
			if(vln.Id>0)
			{
				_context.Volunteers.Update(vln);
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
			var list = _context.Volunteers.ToList().FirstOrDefault(e=>e.Id == id);
			return View(list);
		}
		public IActionResult Delete(int id)
		{
			var list = _context.Volunteers.ToList().FirstOrDefault(e=>e.Id==id);
			if(list !=null)
			{
				_context.Volunteers.Remove(list);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
