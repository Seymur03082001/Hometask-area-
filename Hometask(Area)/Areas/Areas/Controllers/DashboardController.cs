using Microsoft.AspNetCore.Mvc;

namespace Hometask_Area_.Areas.Areas.Controllers
{
    [Area("Admin-Panel")]
    public class DashboardController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
