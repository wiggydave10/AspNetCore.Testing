using Microsoft.AspNetCore.Mvc;

namespace Web.Testing.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}