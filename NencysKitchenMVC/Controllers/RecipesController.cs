using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NencysKitchenMVC.ViewModels;
using NencysKitchenMVC.Services.Interfaces;
using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.RecipesForCreation;

namespace NencysKitchenMVC.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipesController(IRecipeService recipeService, IMapper mapper)
        {
            _recipeService = recipeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> List()
        {
            var recipesDataModel = await _recipeService.GetRecipesAsync();

            var recipes = _mapper.Map<IEnumerable<RecipeViewModel>>(recipesDataModel);
            return View(recipes);
        }

        public async Task<IActionResult> Details(int recipeId)
        {
            var recipeDM = await _recipeService.GetRecipeByIdAsync(recipeId);
            if(recipeDM == null)
            {
                return NotFound();
            }
            var recipe = _mapper.Map<RecipeViewModel>(recipeDM);
            return View(recipe);
        }

        public async Task<IActionResult> Create(RecipeViewModel recipeForCreation)
        {
            var result = _mapper.Map<Recipe>(recipeForCreation);
            var recipe = await _recipeService.Create(result);
            var createdRecipe = _mapper.Map<RecipeViewModel>(recipe);
            if(createdRecipe == null)
            {
                return NotFound();
            }
            return View(createdRecipe);
        }
    }
}
