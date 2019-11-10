using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Foods
{
    public class CreateModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        [BindProperty]
        public FoodStuff FoodStuff { get; set; }
        public CreateModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
            FoodStuff = new FoodStuff();
        }

        public IActionResult OnGet()
        {
        ViewData["FoodGroupId"] = new SelectList(_context.FoodGroup, "FoodGroupId", "FoodGroupName");
            FoodStuff.FoodId = Guid.NewGuid();
            FoodStuff.UpdateDateTime = DateTime.UtcNow;
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FoodStuff.Add(FoodStuff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}