using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
	public class BookController : Controller
	{
		private readonly LibraryDbContext _context;

        public BookController(LibraryDbContext context)
        {
			_context = context;
            
        }
        public IActionResult Index()
		{
			var listOfBooks = _context.Books.ToList();
			return View(listOfBooks);
		}
	}
}
