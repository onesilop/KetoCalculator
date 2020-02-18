using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Foods
{
    public class DeleteModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public DeleteModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FoodStuff FoodStuff { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FoodStuff = await _context.FoodStuff
                .Include(f => f.FoodGroup).FirstOrDefaultAsync(m => m.FoodId == id);

            if (FoodStuff == null)
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

            FoodStuff = await _context.FoodStuff.FindAsync(id);

            if (FoodStuff != null)
            {
                _context.FoodStuff.Remove(FoodStuff);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
