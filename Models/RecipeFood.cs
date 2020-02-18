using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class RecipeFood
    {
        public Guid RecipeId { get; set; }
        public Guid FoodId { get; set; }
        public decimal Grams { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public virtual FoodStuff Food { get; set; }
        public virtual Recipes Recipe { get; set; }
    }
}
