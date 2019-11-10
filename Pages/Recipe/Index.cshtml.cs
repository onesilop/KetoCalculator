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
    public class IndexModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public IndexModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        public IList<Recipes> Recipes { get;set; }

        public async Task OnGetAsync(Boolean All=true,string uId = null )
        {
           if (All || uId == null){
                Recipes = await _context.Recipes
                    .Include(r => r.RecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync(); ;
            }  else
            {
                Recipes = await _context.Recipes.Where(r => r.RecipieUser.ToString() == uId)
                    .Include(r => r.RecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync();
            }
        }
    }
}
