using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Recipe
{
    public class DeleteModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public DeleteModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipes Recipes { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipes = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeId == id);

            if (Recipes == null)
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

            Recipes = await _context.Recipes.FindAsync(id);

            if (Recipes != null)
            {
                _context.Recipes.Remove(Recipes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
