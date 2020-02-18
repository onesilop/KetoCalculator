using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Admin.UserRole
{
    public class EditModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public EditModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AspNetRoleClaims AspNetRoleClaims { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AspNetRoleClaims = await _context.AspNetRoleClaims
                .Include(a => a.Role).FirstOrDefaultAsync(m => m.Id == id);

            if (AspNetRoleClaims == null)
            {
                return NotFound();
            }
           ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AspNetRoleClaims).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetRoleClaimsExists(AspNetRoleClaims.Id))
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

        private bool AspNetRoleClaimsExists(int id)
        {
            return _context.AspNetRoleClaims.Any(e => e.Id == id);
        }
    }
}
