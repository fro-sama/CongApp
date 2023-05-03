namespace CongApp.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }
        public string? Assignment { get; set; }
        public string? Assignee { get; set; }
        public string? Partner { get; set; }

        public Guid MeetingId { get; set; }
    }
}
