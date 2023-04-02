using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencysKitchenMVC.DataModel.RecipesForCreation
{
    public class RecipeStepForCreation
    {
        public int StepNumber { get; set; }
        public string Instruction { get; set; } = string.Empty;
    }
}
