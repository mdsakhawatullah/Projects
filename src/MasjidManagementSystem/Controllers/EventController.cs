using MasjidManagementSystem.DB;
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
    }
}
