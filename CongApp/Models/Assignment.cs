using System.ComponentModel.DataAnnotations;

namespace CongApp.Models
{
    public class Assignment
    {
        [Key]
        public Guid Id { get; set; }
        public string? Task { get; set; }
        public string? Assignee { get; set; }
        public string? Partner { get; set; }
        public string? Section { get; set; }

        public Guid MeetingId { get; set; }
    }
}
