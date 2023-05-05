using CongApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CongApp.Data
{
    public class CongAppDbContext : DbContext
    {
        public CongAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MeetingModel> Meetings { get; set; }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
