using LibraryManagement.DB;
using LibraryManagement.Helper;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StaffController : Controller
    {
        private readonly LibraryDbContext _context;
		private string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
		public StaffController(LibraryDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var listOfStaff = _context.Staffs.ToList();
            return View(listOfStaff);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Staff staff)
        {
			//fiel handle
			var result = FileHelper.SaveFile(staff.UploadedFile, uploadPath);
			if (result)
			{
				staff.FileName = staff.UploadedFile.FileName;
			}
			else
			{
				staff.FileName = "No File Found";
			}
			_context.Staffs.Add(staff);
            _context.SaveChanges();
            return View();

        }
		public IActionResult Update(int id)
		{
			Staff? staff = _context.Staffs.FirstOrDefault(x => x.Id == id);
			return View(staff);
		}

		[HttpPost]
		public IActionResult Update(Staff staff)
		{
			if (staff.Id > 0)
			{
				_context.Staffs.Update(staff);
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
			var list = _context.Staffs.ToList().FirstOrDefault(e => e.Id == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var list = _context.Staffs.ToList().FirstOrDefault(e => e.Id == id);
			if (list != null)
			{
				_context.Staffs.Remove(list);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}


	}
}
