using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class LoanController : Controller
    {
        private readonly LibraryDbContext _context;

        public LoanController(LibraryDbContext context)
        {
            _context = context;   
        }
        public IActionResult Index()
        {
            var listOfLoans = _context.Loans.ToList();
            return View(listOfLoans);
        }
    }
}
