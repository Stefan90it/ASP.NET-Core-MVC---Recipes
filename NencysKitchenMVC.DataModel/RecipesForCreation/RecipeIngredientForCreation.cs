using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencysKitchenMVC.DataModel.RecipesForCreation
{
    public class RecipeIngredientForCreation
    {
        public IngredientForCreation Ingredient { get; set; }
        public MeasurementUnitForCreation MeasurementUnit { get; set; }
        public decimal QtyAmount { get; set; }
    }
}
