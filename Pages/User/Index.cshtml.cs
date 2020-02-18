using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KetoCalculator.Models;
using Microsoft.AspNetCore.Identity;
using KetoCalculator.Areas.Identity.Data;

namespace KetoCalculator.Pages.User
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly KetoCalculator.Models.KetoCalcContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(KetoCalculator.Models.KetoCalcContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager; 
            _context = context;
        }
        public AspNetUsers AspNetUsers { get; set; }

        public IList<UserGoals> UserGoals { get;set; }

        public async Task<IActionResult> OnGetAsync(string uId = null)
        {
            var user = await _userManager.GetUserAsync(User);
            if (uId == null && user.Id != null)
            {
                uId = user.Id;
            }
            else if (user.Id == null)
            {
                return NotFound();
            }
            AspNetUsers = await _context.AspNetUsers.Where(u => u.Id == uId).FirstOrDefaultAsync();
            UserGoals = await _context.UserGoals.Where(g => g.UserId == uId).ToListAsync();
            return Page();
        }
    }
}
