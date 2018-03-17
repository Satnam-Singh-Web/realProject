
using Microsoft.AspNetCore.Mvc;

namespace StockStimulationWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
