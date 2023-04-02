namespace NencysKitchenMVC.DataModel.Recipes
{
    public class FoodCategory
    {
        public int FoodCategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
