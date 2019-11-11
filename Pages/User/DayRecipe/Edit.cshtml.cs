using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.User.DayRecipe
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public EditModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }


        public DayRecipes Recipe { get; set; }
        public IList<DayRecipeFood> RecipeFoods { get; set; }


        public async Task<IActionResult> OnGetAsync(Guid? id = null, long tics = -1)
        {
            if (tics == -1) { tics = DateTime.UtcNow.Date.Ticks; }
            if (id == null)
            {
                Recipe = new DayRecipes();
                RecipeFoods = new List<DayRecipeFood>();
                Recipe.RecipeDate = new DateTime(tics);
            }
            else
            { 
                Recipe = await _context.DayRecipes
                    .Include(r => r.DayRecipeFood).FirstOrDefaultAsync(m => m.RecipeId == id && m.RecipeDate == new DateTime(tics));
                RecipeFoods = await _context.DayRecipeFood.Where(rf => rf.RecipeId == Recipe.RecipeId)
                    .Include(f => f.Food).ToListAsync();
            }
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {

            if (Recipe.RecipeId==null)
            {
                Recipe.RecipeId = Guid.NewGuid();
            }
            Recipe.UpdateDateTime = DateTime.UtcNow;
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (RecipesExists(Recipe.RecipeId))
            {
                _context.Attach(Recipe).State = EntityState.Modified;
            }
            else
            {
                _context.DayRecipes.Add(Recipe);
            }

            foreach (DayRecipeFood rf in _context.DayRecipeFood.Where(r=>r.RecipeId == Recipe.RecipeId).ToList())
            {
                DayRecipeFood RF2 = RecipeFoods.Where(f => f.FoodId == rf.FoodId && f.RecipeId == rf.RecipeId && f.Grams != rf.Grams).FirstOrDefault();
                if (RF2 != null)
                {
                    rf.Grams = RF2.Grams;
                    _context.Attach(rf).State = EntityState.Modified;
                }
            }
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipesExists(Recipe.RecipeId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecipesExists(Guid id)
        {
            return _context.DayRecipes.Any(e => e.RecipeId == id);
        }
    }
}
