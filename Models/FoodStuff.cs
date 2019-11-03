using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class FoodStuff
    {
        public FoodStuff()
        {
            RecipeFood = new HashSet<RecipeFood>();
        }

        public Guid FoodId { get; set; }
        public Guid FoodGroupId { get; set; }
        public string FoodName { get; set; }
        public decimal ProteinPer100 { get; set; }
        public decimal FatPer100 { get; set; }
        public decimal CarbPer100 { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public virtual FoodGroup FoodGroup { get; set; }
        public virtual ICollection<RecipeFood> RecipeFood { get; set; }
    }
}
