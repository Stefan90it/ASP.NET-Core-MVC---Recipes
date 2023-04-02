using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.RecipesForCreation;
using NencysKitchenMVC.DataModel.User;

namespace NencysKitchenMVC.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetRecipesAsync();
        Task<Recipe> GetRecipeByIdAsync(int recipeId);
        Task<Recipe> Create(Recipe recipe);
    }
}
