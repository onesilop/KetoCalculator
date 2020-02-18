using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Foodgroups
{
    public class CreateModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public CreateModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
            FoodGroup = new FoodGroup();
        }

        [BindProperty]
        public FoodGroup FoodGroup { get; set; }

        public IActionResult OnGet()
        {
            FoodGroup.FoodGroupId = Guid.NewGuid();
            FoodGroup.UpdateDatetime = DateTime.UtcNow;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FoodGroup.Add(FoodGroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}