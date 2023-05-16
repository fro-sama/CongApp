using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages.Duties
{
    public class EditModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public EditModel(CongApp.Data.CongAppDbContext context)
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

            var duty =  await _context.Duty.FirstOrDefaultAsync(m => m.Id == id);
            if (duty == null)
            {
                return NotFound();
            }
            Duty = duty;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Duty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DutyExists(Duty.Id))
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

        private bool DutyExists(Guid id)
        {
          return (_context.Duty?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
