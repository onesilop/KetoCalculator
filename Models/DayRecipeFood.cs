using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class DayRecipeFood
    {
        public Guid RecipeId { get; set; }
        public Guid FoodId { get; set; }
        public DateTime RecipeDate { get; set; }
        public decimal Grams { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
