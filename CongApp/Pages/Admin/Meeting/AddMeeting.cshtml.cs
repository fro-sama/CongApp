using CongApp.Pages.Admin.Meeting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongApp.Pages
{
    public class AddMeetingModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public AddMeetingModel(CongApp.Data.CongAppDbContext context)
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
}