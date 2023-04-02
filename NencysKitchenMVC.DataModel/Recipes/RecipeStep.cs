namespace NencysKitchenMVC.DataModel.Recipes
{
    public class RecipeStep
    {
        public int RecipeStepId { get; set; }
        public int? StepNumber { get; set; }
        public string Instruction { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
