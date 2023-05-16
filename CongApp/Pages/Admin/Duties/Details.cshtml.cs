using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages.Duties
{
    public class DetailsModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public DetailsModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

      public Duty Duty { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Duty == null)
            {
                return NotFound();
            }

            var duty = await _context.Duty.FirstOrDefaultAsync(m => m.Id == id);
            if (duty == null)
            {
                return NotFound();
            }
            else 
            {
                Duty = duty;
            }
            return Page();
        }
    }
}
