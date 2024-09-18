using MasjidManagementSystem.DB;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagementSystem.Controllers
{
    public class DonationController : Controller
    {
        private readonly MasjidDbContext _context;
        public DonationController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listOfDonarName = _context.Donations.ToList();
            return View(listOfDonarName);
        }
    }
}
