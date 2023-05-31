using CongApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CongApp.Pages.Meetings
{
    public class MidweekModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public MidweekModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<SelectListItem> Assignees { get; set; }

        [BindProperty]
        public List<SelectListItem> Duties { get; set; }
        public Meeting Meeting { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Meetings == null)
            {
                return NotFound();
            }

            Assignees = await _context.Assignee.Select(i => new SelectListItem
            {
                Text = i.FirstName,
                Value = i.FirstName
            }).ToListAsync();

            Duties = await _context.Duty.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Name
            }).ToListAsync();

            var meeting = await _context.Meetings.Include(i=> i.Assignments).FirstOrDefaultAsync(m => m.Id == id);
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

