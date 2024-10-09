using LibraryManagement.DB;
using LibraryManagement.Helper;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
	public class BookController : Controller
	{
		private readonly LibraryDbContext _context;
		private string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

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
			//var model = new Book();
			return View();
		}
		[HttpPost]
		public IActionResult Create(Book book)
		{
			if (ModelState.IsValid)
			{
				// Handle file upload
				if (book.UploadedFile != null)
				{
					var result = FileHelper.SaveFile(book.UploadedFile, uploadPath);
					if (result)
					{
						
						book.FileName = book.UploadedFile.FileName;
					}
					else
					{
						
						book.FileName = "No File Found";
					}
				}

				// Add the new book to the database
				_context.Books.Add(book);
				_context.SaveChanges();

				
				return View(book);
			}

			// If the model state is invalid, return the same view with the model
			return View(book);
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

		public IActionResult DownloadFile(int id)
		{
			var library = _context.Books.Find(id);
			var fileName = library.FileName;

			if(library == null || string.IsNullOrEmpty(fileName))
			{
				return NotFound();
			}

			//Create the full path to the file
			var downloadPath = Path.Combine(uploadPath, fileName);

			//check if the exist
			if(!System.IO.File.Exists(downloadPath))
			{
				return NotFound();
			}
			var fileStream = FileHelper.FileStream(downloadPath);
			if(fileStream != null)
			{
				var contentType = FileHelper.GetContentType(fileName);
				return File(fileStream, contentType, library.FileName);
			}
			return NotFound();

		}
	}
}
