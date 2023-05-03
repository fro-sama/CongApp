using System.Security.Principal;

namespace CongApp.Models
{
    public class MeetingModel
    {
        public Guid Id { get; set; }

        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public string? Week { get; set; }
    }
}
