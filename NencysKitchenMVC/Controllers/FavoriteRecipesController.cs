using Microsoft.AspNetCore.Mvc;

namespace NencysKitchenMVC.Controllers
{
    public class FavoriteRecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
