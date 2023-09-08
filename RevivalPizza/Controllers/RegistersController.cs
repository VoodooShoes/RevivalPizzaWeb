using Microsoft.AspNetCore.Mvc;

namespace RevivalPizza.Controllers
{
    public class RegistersController : Controller
    {
        public IActionResult RegistersView()
        {
            return View("RegistersView");
        }
    }
}
