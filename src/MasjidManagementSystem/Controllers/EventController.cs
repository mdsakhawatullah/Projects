using MasjidManagementSystem.DB;
using MasjidManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagementSystem.Controllers
{
    public class EventController : Controller
    {
        private readonly MasjidDbContext _context;
        public EventController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listOfEvents = _context.Events.ToList();
            return View(listOfEvents);
        }
        public IActionResult Create()
        {
          
            return View();

        }
        [HttpPost]
        public IActionResult Create(Event eve)
        {
            _context.Events.Add(eve);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Event? eve = _context.Events.ToList().FirstOrDefault(e => e.Id == id);
            return View(eve);
        }
        [HttpPost]
        public IActionResult Update(Event eve)
        {
            if(eve.Id > 0)
            {
                _context.Events.Update(eve);
                _context.SaveChanges(true);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
		public IActionResult Details(int id)
		{
			var list = _context.Events.ToList().FirstOrDefault(e => e.Id == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Events.ToList().FirstOrDefault(e => e.Id == id);
			if (library != null)
			{
				_context.Events.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
