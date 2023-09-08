using Microsoft.AspNetCore.Mvc;

namespace RevivalPizza.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult MenuView()
        {
            return View("MenuView");
        }
    }
}
