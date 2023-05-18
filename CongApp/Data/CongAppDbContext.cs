using CongApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CongApp.Data
{
    public class CongAppDbContext : DbContext
    {
        public CongAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<Assignment> Assignments { get; set; }


        public DbSet<Assignee>? Assignee { get; set; }


        public DbSet<CongApp.Models.Duty>? Duty { get; set; }
    }
}
