using Microsoft.AspNetCore.Mvc;

namespace RevivalPizza.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View("OrdersView");
        }
    }
}
