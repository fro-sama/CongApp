using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongApp.Pages.Admin.Task
{
    public class TaskModel : PageModel
    {
        [BindProperty]
        public AddTask AddTaskRequest { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
        }
    }
}
