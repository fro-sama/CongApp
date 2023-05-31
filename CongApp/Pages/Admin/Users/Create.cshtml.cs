using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public CreateModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Assignee Assignee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Assignee == null || Assignee == null)
            {
                return Page();
            }

            _context.Assignee.Add(Assignee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
