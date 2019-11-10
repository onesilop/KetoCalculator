using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace KetoCalculator.Pages.Recipe.RecipeFoods
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public CreateModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }


        public RecipeFood RecipeFood { get; set; }
        public FoodGroup Available_Foodgroups { get; set; }
        public IActionResult OnGet(Guid recid)
        {
            if (recid == null) 
            { 
                return NotFound(); 
            }
            RecipeFood = new RecipeFood();
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

            RecipeFood rf = _context.RecipeFood.Where(r => r.FoodId == RecipeFood.FoodId && r.RecipeId == RecipeFood.RecipeId).FirstOrDefault();
            if (rf != null)
            {
                rf.Grams += RecipeFood.Grams;
                _context.RecipeFood.Attach(rf).State = EntityState.Modified;
            }
            else
            { 
                _context.RecipeFood.Add(RecipeFood);
            }
            await _context.SaveChangesAsync();
                     

            return RedirectToPage("/Recipe/Edit", new Dictionary<string, string> { { "id", recid.ToString() } });
        }
    }
}