using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NencysKitchenMVC.ViewModels;
using NencysKitchenMVC.Services.Interfaces;
using System.Diagnostics;

namespace NencysKitchenMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IRecipeService recipeService, IMapper mapper)
        {
            _logger = logger;
            _recipeService = recipeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var recipesDataModel = await _recipeService.GetRecipesAsync();

            var recipes = _mapper.Map<IEnumerable<RecipeViewModel>>(recipesDataModel);
            return View(recipes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}