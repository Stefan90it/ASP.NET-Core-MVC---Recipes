
namespace NencysKitchenMVC.DataModel.Recipes
{
    public class MeasurementUnit
    {
        public int MeasurementUnitId { get; set; }
        public string? MeasurementName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
