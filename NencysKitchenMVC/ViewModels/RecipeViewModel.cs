using NencysKitchenMVC.DataModel.Recipes;

namespace NencysKitchenMVC.ViewModels
{
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Serves { get; set; }
        public bool IsRecipeOfTheDay { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public ICollection<Course>? Courses { get; set; } = default!;
        public ICollection<FoodCategory>? FoodCategories { get; set; } = default!;
        public ICollection<RecipeIngredient>? RecipeIngredients { get; set; } = default!;
        public ICollection<RecipeStep> RecipeStep { get; set; } = default!;
    }
}
