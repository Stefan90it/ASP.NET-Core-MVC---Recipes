using Microsoft.AspNetCore.Mvc;

namespace NencysKitchenMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
