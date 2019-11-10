using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KetoCalculator.Models
{
    public partial class FoodGroup
    {
        public FoodGroup()
        {
            FoodStuff = new HashSet<FoodStuff>();
        }

        public Guid FoodGroupId { get; set; }

        [DisplayName("Food Group")]
        public string FoodGroupName { get; set; }

        [DisplayName("Last Updated")]
        public DateTime UpdateDatetime { get; set; }

        public virtual ICollection<FoodStuff> FoodStuff { get; set; }
    }
}
