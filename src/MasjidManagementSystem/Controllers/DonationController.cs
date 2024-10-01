using MasjidManagementSystem.DB;
using MasjidManagementSystem.Models;
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
        #region Create Method
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Donation donation)
        {
            _context.Donations.Add(donation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
		#endregion
		public IActionResult Update(int id)
        {
            Donation? donation = _context.Donations.ToList().FirstOrDefault(e => e.Id == id);
            return View(donation);
        }
        [HttpPost]
        public IActionResult Update(Donation donation)
        {
            if(donation.Id>0)
            {
                _context.Donations.Update(donation);
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
			var list = _context.Donations.ToList().FirstOrDefault(e => e.Id == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Donations.ToList().FirstOrDefault(e => e.Id == id);
			if (library != null)
			{
				_context.Donations.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
