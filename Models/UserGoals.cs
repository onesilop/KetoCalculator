using System;
using System.Collections.Generic;

namespace KetoCalculator.Models
{
    public partial class UserGoals
    {
        public Guid GoalId { get; set; }
        public string UserId { get; set; }
        public DateTime GoalDate { get; set; }
        public decimal GoalCalories { get; set; }
        public decimal GoalRatio { get; set; }
        public Guid? RecipeType { get; set; }
    }
}
