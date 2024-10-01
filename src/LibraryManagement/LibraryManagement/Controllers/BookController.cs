using LibraryManagement.DB;
using LibraryManagement.Models;
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

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
			return View();
		}

		public IActionResult Update(int id)
		{
			Book? book = _context.Books.ToList().FirstOrDefault(x=>x.Id==id);
			return View(book);

		}
		[HttpPost]
		public IActionResult Update(Book book)
		{
			if(book.Id >0)
			{
				_context.Books.Update(book);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View(book);
			}

		}
		public IActionResult Details(int id)
		{
			var list = _context.Books.ToList().FirstOrDefault(e => e.Id == id); 
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Books.ToList().FirstOrDefault(e=>e.Id==id);
			if(library!=null)
			{
				_context.Books.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
