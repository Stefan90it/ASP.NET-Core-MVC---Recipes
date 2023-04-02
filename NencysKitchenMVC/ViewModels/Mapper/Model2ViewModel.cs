using AutoMapper;
using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.RecipesForCreation;
using NencysKitchenMVC.DataModel.User;

namespace NencysKitchenMVC.ViewModels.Mapper
{
    public class Model2ViewModel : Profile
    {
        public Model2ViewModel()
        {
            this.CreateMap<Recipe, RecipeViewModel>();
            this.CreateMap<RecipeViewModel, Recipe>();
            this.CreateMap<User, RegisterViewModel>();
            this.CreateMap<RegisterViewModel, User>();
        }
    }
}
