using CongApp.Pages.Admin.Meeting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongApp.Pages
{
    public class AddMeetingModel : PageModel
    {
        private readonly ILogger<AddMeetingModel> _logger;

        public AddMeetingModel(ILogger<AddMeetingModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public AddNewMeeting AddNewMeetingRequest { get; set; }

        public void OnGet()
        {

        }

        public void OnPost() 
        {

        }
    }
}