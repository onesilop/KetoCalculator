using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KetoCalculator.Models
{
    public partial class FoodStuff
    {
        public FoodStuff()
        {
            DayRecipeFood = new HashSet<DayRecipeFood>();
            RecipeFood = new HashSet<RecipeFood>();
        }

        public decimal Calories
        {
            get
            {
                return (ProteinPer100 * 4) + (FatPer100 * 9) + (CarbPer100 * 4);
            }
        }

        public decimal Ratio
        {
            get
            {
                decimal agg = ProteinPer100 + CarbPer100;
                if (agg == 0) { agg = 1; }
                return (FatPer100 / agg);
            }
        }

        public Guid FoodId { get; set; }

        [DisplayName("Food Group")]
        public Guid FoodGroupId { get; set; }

        [DisplayName("Name")]
        public string FoodName { get; set; }

        [DisplayName("Protein (Per 100g)")]
        public decimal ProteinPer100 { get; set; }

        [DisplayName("Fat (Per 100g)")]
        public decimal FatPer100 { get; set; }

        [DisplayName("Carbohydrates (Per 100g)")]
        public decimal CarbPer100 { get; set; }

        [DisplayName("Last Updated")]
        public DateTime UpdateDateTime { get; set; }

        public virtual FoodGroup FoodGroup { get; set; }
        public virtual ICollection<DayRecipeFood> DayRecipeFood { get; set; }
        public virtual ICollection<RecipeFood> RecipeFood { get; set; }
    }
}
