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
    public class DeleteModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public DeleteModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Duty == null)
            {
                return NotFound();
            }
            var duty = await _context.Duty.FindAsync(id);

            if (duty != null)
            {
                Duty = duty;
                _context.Duty.Remove(Duty);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
