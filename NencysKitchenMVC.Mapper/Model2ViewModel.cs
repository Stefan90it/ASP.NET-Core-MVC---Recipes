using Mapster;
using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencysKitchenMVC.Mapper
{
    public class Model2ViewModel : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Recipe, RecipeViewModel>();
        }
    }
}
