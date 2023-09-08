using Microsoft.AspNetCore.Mvc;

namespace RevivalPizza.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutView()
        {
            return View("AboutView");
        }
    }
}
