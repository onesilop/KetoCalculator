using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class DayRecipes
    {
        public Guid RecipeId { get; set; }
        public string RecipeName { get; set; }
        public Guid RecipieUser { get; set; }
        public DateTime RecipeDate { get; set; }
        public decimal Calories { get; set; }
        public decimal Ratio { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
