using Microsoft.AspNetCore.Mvc;

namespace SquadManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
