using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace LibraryManagement.Controllers
{
	public class MemberController : Controller
	{
		private readonly LibraryDbContext _context;
		public MemberController(LibraryDbContext context)
		{
			_context = context; 
		}
		public IActionResult Index()
		{
			var listOfMember = _context.Members.ToList();
			return View(listOfMember);
		}
	}
}
