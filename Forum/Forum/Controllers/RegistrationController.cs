using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
