using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Foodgroups
{
    public class EditModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public EditModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FoodGroup FoodGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FoodGroup = await _context.FoodGroup.FirstOrDefaultAsync(m => m.FoodGroupId == id);

            if (FoodGroup == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FoodGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodGroupExists(FoodGroup.FoodGroupId))
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

        private bool FoodGroupExists(Guid id)
        {
            return _context.FoodGroup.Any(e => e.FoodGroupId == id);
        }
    }
}
