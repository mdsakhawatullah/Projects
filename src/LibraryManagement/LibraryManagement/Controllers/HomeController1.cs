using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
