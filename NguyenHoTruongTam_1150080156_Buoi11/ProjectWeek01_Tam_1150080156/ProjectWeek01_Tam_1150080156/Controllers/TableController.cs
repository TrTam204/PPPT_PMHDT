using Microsoft.AspNetCore.Mvc;

namespace ProjectWeek01.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
