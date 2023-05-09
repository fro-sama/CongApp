using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongApp.Pages.Admin.Task
{
    public class AssignmentModel : PageModel
    {
        [BindProperty]
        public AddAssignment AddAssignment { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
        }
    }
}
