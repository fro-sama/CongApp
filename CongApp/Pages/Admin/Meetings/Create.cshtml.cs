using CongApp.Models;
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

            var meeting = new Models.Meeting
            {
                Date = AddNewMeetingRequest.Date,
                Type = AddNewMeetingRequest.Type,
                Week = AddNewMeetingRequest.Week,
            };

            if(meeting.Type == "Midweek")
            {
                meeting = MeetingFactory.CreateMidWeek(AddNewMeetingRequest.Date, AddNewMeetingRequest.Week);
            };
            _context.Meetings.Add(meeting);
            await _context.SaveChangesAsync();

            if(meeting.Type == "Midweek")
            {
                return RedirectToPage("Midweek", new { id = meeting.Id });
            }
            return RedirectToPage("Details", new { id = meeting.Id });
        }
    }
    public class AddNewMeeting
    {
        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public string? Week { get; set; }
    }
}