using NencysKitchenMVC.DataModel.Recipes;

namespace NencysKitchenMVC.ViewModels
{
    public class RecipeIngredientViewModel
    {
        public int RecipeIngredientId { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int? MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public double QtyAmount { get; set; }
    }
}
