using Microsoft.AspNetCore.Mvc;

namespace aga_project.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
