using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            RecipeFood = new HashSet<RecipeFood>();
        }

        public Guid RecipeId { get; set; }
        public string RecipeName { get; set; }
        public Guid? RecipieUser { get; set; }
        public decimal Calories { get; set; }
        public decimal Ratio { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public virtual ICollection<RecipeFood> RecipeFood { get; set; }
    }
}
