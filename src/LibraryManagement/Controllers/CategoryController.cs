using LibraryManagement.DB;
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
    }
}
