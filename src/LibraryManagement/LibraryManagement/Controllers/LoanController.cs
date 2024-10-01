using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Update(int bookId)
        {
            Loan? loan = _context.Loans.ToList().FirstOrDefault(x=>x.BookID == bookId);
            return View(loan);
        }

        [HttpPost]
        public IActionResult Update(Loan loan)
        {
            if (loan.BookID > 0)
            {
                _context.Loans.Update(loan);
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
			var list = _context.Loans.ToList().FirstOrDefault(e => e.BookID == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Loans.ToList().FirstOrDefault(e => e.BookID == id);
			if (library != null)
			{
				_context.Loans.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}

	}
}
