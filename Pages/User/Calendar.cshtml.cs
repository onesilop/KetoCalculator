using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KetoCalculator.Areas.Identity.Data;
using KetoCalculator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KetoCalculator.Pages.User
{
    public class CalendarModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public IList<DayRecipes> DayRecipes { get; set; }


        public CalendarModel(KetoCalculator.Models.KetoCalcContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
            DayRecipes = new List<DayRecipes>();
        }
        public async void OnGetAsync(bool All = true, string uId = null)
        {
            if (All || uId == null)
            {
                DayRecipes = await _context.DayRecipes
                    .Include(r => r.DayRecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync(); ;
            }
            else
            {
                DayRecipes = await _context.DayRecipes.Where(r => r.RecipeUser.ToString() == uId)
                    .Include(r => r.DayRecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync();
            }
        }
    }
}
