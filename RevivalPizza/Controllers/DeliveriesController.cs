using Microsoft.AspNetCore.Mvc;

namespace RevivalPizza.Controllers
{
    public class DeliveriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
