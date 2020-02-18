using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.User
{
    public class DeleteModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public DeleteModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserGoals UserGoals { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserGoals = await _context.UserGoals.FirstOrDefaultAsync(m => m.GoalId == id);

            if (UserGoals == null)
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

            UserGoals = await _context.UserGoals.FindAsync(id);

            if (UserGoals != null)
            {
                _context.UserGoals.Remove(UserGoals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
