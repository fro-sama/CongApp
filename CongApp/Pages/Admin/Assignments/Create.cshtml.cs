using CongApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CongApp.Pages.Admin.Assignments
{
    public class CreateModel : PageModel
    {

        private readonly CongApp.Data.CongAppDbContext _context;

        public CreateModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public AddAssignment AddAssignment { get; set; }

        [BindProperty]
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
            Meeting = meeting;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            _context.Assignments.Add(
               new Models.Assignment
               {
                   Task = AddAssignment.Assignment,
                   Assignee = AddAssignment.Assignee,
                   Partner = AddAssignment.Partner,
                   MeetingId = Meeting.Id,
               });
            await _context.SaveChangesAsync();
            return RedirectToPage("../Meetings/Details", new  { Id = Meeting.Id});
        }
    }
}
