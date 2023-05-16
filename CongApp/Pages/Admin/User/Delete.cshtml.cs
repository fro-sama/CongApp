using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages.Admin.User
{
    public class DeleteModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public DeleteModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Assignee Assignee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Assignee == null)
            {
                return NotFound();
            }

            var assignee = await _context.Assignee.FirstOrDefaultAsync(m => m.Id == id);

            if (assignee == null)
            {
                return NotFound();
            }
            else 
            {
                Assignee = assignee;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Assignee == null)
            {
                return NotFound();
            }
            var assignee = await _context.Assignee.FindAsync(id);

            if (assignee != null)
            {
                Assignee = assignee;
                _context.Assignee.Remove(Assignee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
