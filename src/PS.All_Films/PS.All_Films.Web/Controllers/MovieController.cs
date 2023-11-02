using Microsoft.AspNetCore.Mvc;

namespace PS.All_Films.Web.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
