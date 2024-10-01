using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly LibraryDbContext _context;
        public CategoryController(LibraryDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var listOfCategory = _context.Categories.ToList();
            return View(listOfCategory);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Update(int id)
        {
            Category? category = _context.Categories.ToList().FirstOrDefault(x => x.Id == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if(category.Id> 0)
            {
                _context.Categories.Update(category);
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
			var list = _context.Categories.ToList().FirstOrDefault(e => e.Id == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var list = _context.Categories.ToList().FirstOrDefault(e => e.Id == id);
			if (list!= null)
			{
				_context.Categories.Remove(list);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}


	}
}
