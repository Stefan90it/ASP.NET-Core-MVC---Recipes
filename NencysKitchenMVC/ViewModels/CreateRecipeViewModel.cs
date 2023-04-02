using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NencysKitchenMVC.ViewModels
{
    public class CreateRecipeViewModel
    {
        [BindNever]
        public int RecipeId { get; set; }

        public List<RecipeViewModel>? CreateRecipe { get; set; }

        [Required(ErrorMessage = "Unesite naziv recepta")]
        [Display(Name = "Recipe name")]
        [StringLength(50)]
        public string RecipeName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Unesite kratak opis")]
        [Display(Name = "Last name")]
        [StringLength(100)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Unesite opis")]
        [StringLength(500)]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; } = string.Empty;

        [Display(Name = "Serves")]
        public int? Serves { get; set; }
    }
}
