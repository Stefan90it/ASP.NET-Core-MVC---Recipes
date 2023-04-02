using Microsoft.Extensions.Configuration;
using NencysKitchenMVC.DataModel;
using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.RecipesForCreation;
using NencysKitchenMVC.Services.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace NencysKitchenMVC.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly HttpClient _recipeRestServise;
        private readonly IConfiguration _configuration;

        public RecipeService(IConfiguration configuration)
        {
            _configuration = configuration;
            _recipeRestServise = new HttpClient();
            _recipeRestServise.BaseAddress = new Uri(_configuration.GetSection("ExternalServices").GetSection("NencysKitchenAPI").Value);

        }

        public async Task<Recipe> Create(Recipe recipe)
        {
            try
            {
                var json = JsonConvert.SerializeObject(recipe);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await _recipeRestServise.PostAsync($"Recipe", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    recipe = JsonConvert.DeserializeObject<Recipe>(content);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recipe;
        }

        public async Task<Recipe> GetRecipeByIdAsync(int recipeId)
        {
            var recipe = new Recipe();
            try
            {
                var response = await _recipeRestServise.GetAsync($"Recipes/{recipeId}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    recipe = JsonConvert.DeserializeObject<Recipe>(content);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recipe;
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            var result = new List<Recipe>();
            try
            {
                var response = await _recipeRestServise.GetAsync("Recipes");
                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Recipe>>(content);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
