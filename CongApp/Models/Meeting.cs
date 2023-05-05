using System.Security.Principal;

namespace CongApp.Models
{
    public class Meeting
    {
        public Guid Id { get; set; }

        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public string? Week { get; set; }
    }
}
