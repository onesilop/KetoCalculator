﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.User.DayRecipe
{
    public class IndexModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public IndexModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        public IList<DayRecipes> Recipes { get;set; }

        public async Task OnGetAsync(bool All =true,string uId = null )
        {
           if (All || uId == null){
                Recipes = await _context.DayRecipes
                    .Include(r => r.DayRecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync(); ;
            }  else
            {
                Recipes = await _context.DayRecipes.Where(r => r.RecipeUser.ToString() == uId)
                    .Include(r => r.DayRecipeFood)
                    .ThenInclude(f => f.Food)
                    .ToListAsync();
            }
        }
    }
}
