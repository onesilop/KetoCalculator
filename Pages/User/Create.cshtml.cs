using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public CreateModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserGoals UserGoals { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserGoals.Add(UserGoals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}