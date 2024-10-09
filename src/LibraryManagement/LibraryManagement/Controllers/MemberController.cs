using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using LibraryManagement.Models;
using LibraryManagement.Helper;

namespace LibraryManagement.Controllers
{
	public class MemberController : Controller
	{
		private readonly LibraryDbContext _context;
		private string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
		public MemberController(LibraryDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var listOfMember = _context.Members.ToList();
			return View(listOfMember);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Member member)
		{
			//fiel handle
			var result = FileHelper.SaveFile(member.UploadedFile, uploadPath);
			if (result)
			{
				member.FileName = member.UploadedFile.FileName;
			}
			else
			{
				member.FileName = "No File Found";
			}
			_context.Members.Add(member);
			_context.SaveChanges();
			return View();

		}

		public IActionResult Update(int memberId)
		{
			Member? member = _context.Members.FirstOrDefault(x=>x.MembershipNumber == memberId);
			return View(member);
		}

		[HttpPost]
		public IActionResult Update(Member member)
		{
			if(member.MembershipNumber > 0)
			{
				_context.Members.Update(member);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View(member);
			}
		}
		public IActionResult Details(int id)
		{
			var list = _context.Members.ToList().FirstOrDefault(e => e.MembershipNumber == id);
			return View(list);
		}

		public IActionResult Delete(int id)
		{
			var library = _context.Members.ToList().FirstOrDefault(e => e.MembershipNumber == id);
			if (library != null)
			{
				_context.Members.Remove(library);
				_context.SaveChanges(true);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
