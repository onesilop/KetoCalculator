using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;

namespace KetoCalculator.Pages.Foodgroups
{
    public class IndexModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;

        public IndexModel(KetoCalculator.Models.KetoCalcContext context)
        {
            _context = context;
        }

        public IList<FoodGroup> FoodGroup { get;set; }

        public async Task OnGetAsync()
        {
            FoodGroup = await _context.FoodGroup.ToListAsync();
        }
    }
}
