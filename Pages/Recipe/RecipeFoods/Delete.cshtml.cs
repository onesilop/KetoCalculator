using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Recipe.RecipeFoods
{
    public class DeleteModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public DeleteModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RecipeFood RecipeFood { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecipeFood = await _context.RecipeFood
                .Include(r => r.Food)
                .Include(r => r.Recipe).FirstOrDefaultAsync(m => m.RecipeId == id);

            if (RecipeFood == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecipeFood = await _context.RecipeFood.FindAsync(id);

            if (RecipeFood != null)
            {
                _context.RecipeFood.Remove(RecipeFood);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
