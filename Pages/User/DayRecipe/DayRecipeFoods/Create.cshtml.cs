﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.User.DayRecipe.RecipeFoods
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public CreateModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }


        public DayRecipeFood RecipeFood { get; set; }
        public FoodGroup Available_Foodgroups { get; set; }
        public IActionResult OnGet(Guid recid)
        {
            if (recid == null) 
            { 
                return NotFound(); 
            }
            RecipeFood = new DayRecipeFood();
            RecipeFood.RecipeId = recid;
            RecipeFood.Grams = 0;
            ViewData["FoodGroupId"] = new SelectList(_context.FoodGroup, "FoodGroupId", "FoodGroupName");
            return Page();
        }

        public JsonResult OnGetFoods(Guid FoodGroupId)
        {
            return new JsonResult(_context.FoodStuff.Where(f => f.FoodGroup.FoodGroupId == FoodGroupId).ToList());
        }


        public async Task<IActionResult> OnPostAsync(Guid recid)
        {
            RecipeFood.UpdateDateTime = DateTime.UtcNow;
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DayRecipeFood.Add(RecipeFood);
            await _context.SaveChangesAsync();

            return RedirectToPage("/User/DayRecipe/Edit", new Dictionary<string, string> { { "id", recid.ToString() } });
        }
    }
}