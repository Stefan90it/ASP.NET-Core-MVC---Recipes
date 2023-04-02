namespace NencysKitchenMVC.DataModel.Recipes
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
