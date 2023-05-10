using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongApp.Pages.Admin.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public CreateModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
            AddNewMeetingRequest = new AddNewMeeting();
        }

        [BindProperty]
        public AddNewMeeting AddNewMeetingRequest { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost() 
        {
            _context.Meetings.Add(
                new Models.Meeting { 
                    Date = AddNewMeetingRequest.Date,
                    Type = AddNewMeetingRequest.Type,   
                    Week = AddNewMeetingRequest.Week,   
            });
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
    public class AddNewMeeting
    {
        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public string? Week { get; set; }
    }
}