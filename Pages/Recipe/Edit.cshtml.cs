using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Recipe
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public EditModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }


        public Recipes Recipe { get; set; }
        public IList<RecipeFood> RecipeFoods { get; set; }


        public async Task<IActionResult> OnGetAsync(Guid? id = null)
        {
            if (id == null)
            {
                Recipe = new Recipes();
                RecipeFoods = new List<RecipeFood>();
            }
            else
            { 
                Recipe = await _context.Recipes
                    .Include(r => r.RecipeFood).FirstOrDefaultAsync(m => m.RecipeId == id);
                RecipeFoods = await _context.RecipeFood.Where(rf => rf.RecipeId == Recipe.RecipeId)
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
                _context.Recipes.Add(Recipe);
            }

            foreach (RecipeFood rf in _context.RecipeFood.Where(r=>r.RecipeId == Recipe.RecipeId).ToList())
            {
                RecipeFood RF2 = RecipeFoods.Where(f => f.FoodId == rf.FoodId && f.RecipeId == rf.RecipeId && f.Grams != rf.Grams).FirstOrDefault();
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
            return _context.Recipes.Any(e => e.RecipeId == id);
        }
    }
}
