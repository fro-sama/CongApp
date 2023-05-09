using CongApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CongApp.Pages.Meetings
{
    public class DetailsModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public DetailsModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }
        public Meeting Meeting { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Meetings == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings.FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }
            else
            {
                Meeting = meeting;
            }
            return Page();
        }
    }
}

