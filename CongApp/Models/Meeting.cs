using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace CongApp.Models
{
    public class Meeting
    {
        [Key]
        public Guid Id { get; set; }

        public string? Type { get; set; }
        public DateTime Date { get; set; }
        public string? Week { get; set; }

        public List<Assignment> Assignments { get; set; }   
    }
}
