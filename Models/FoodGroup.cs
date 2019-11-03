using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class FoodGroup
    {
        public FoodGroup()
        {
            FoodStuff = new HashSet<FoodStuff>();
        }

        public Guid FoodGroupId { get; set; }
        public string FoodGroupName { get; set; }
        public DateTime UpdateDatetime { get; set; }

        public virtual ICollection<FoodStuff> FoodStuff { get; set; }
    }
}
