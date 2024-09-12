using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StaffController : Controller
    {
        private readonly LibraryDbContext _context;
        public StaffController(LibraryDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var listOfStaff = _context.Staffs.ToList();
            return View(listOfStaff);
        }
    }
}
