using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KetoCalculator.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            RecipeFood = new HashSet<RecipeFood>();
        }

        public Guid RecipeId { get; set; }
        [DisplayName("Name")]
        public string RecipeName { get; set; }
        [DisplayName("Method")]
        public string RecipeMethod { get; set; }
        public Guid? RecipeUser { get; set; }
        public decimal Calories { get; set; }
        public decimal Ratio { get; set; }
        [DisplayName("Last Updated")]
        public DateTime UpdateDateTime { get; set; }

        public virtual ICollection<RecipeFood> RecipeFood { get; set; }

        public decimal CalcCalories {
            get
            {
                decimal retval;
                retval = 0;
                foreach (RecipeFood rf in RecipeFood)
                {
                    retval += (rf.Food.Calories / 100) * rf.Grams;
                }
                return retval;
            }
        }
        public decimal CalcRatio {
            get
            {
                decimal agg = CalcProtein+ CalcCarb;
                if (agg == 0) { agg = 1; }
                return (CalcFat / agg);
            } 
        }

        public decimal CalcProtein
        {
            get {
                decimal agg = 0;
                foreach (RecipeFood rf in RecipeFood)
                {
                    agg += (rf.Food.ProteinPer100 / 100) * rf.Grams;
                }
                return agg;
            }

                }
        public decimal CalcFat
        {
            get
            {
                decimal agg = 0;
                foreach (RecipeFood rf in RecipeFood)
                {
                    agg += (rf.Food.FatPer100 / 100) * rf.Grams;
                }
                return agg;
            }
        }

        public decimal CalcCarb
        {
            get
            {
                decimal agg = 0;
                foreach (RecipeFood rf in RecipeFood)
                {
                    agg += (rf.Food.CarbPer100 / 100) * rf.Grams;
                }
                return agg;
            }
        }
    }
}
