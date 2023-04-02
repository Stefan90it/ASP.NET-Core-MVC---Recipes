namespace NencysKitchenMVC.DataModel.Recipes
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
