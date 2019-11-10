using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Admin.UserRole
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
        ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public AspNetRoleClaims AspNetRoleClaims { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AspNetRoleClaims.Add(AspNetRoleClaims);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}