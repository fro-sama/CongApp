using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages
{
    public class MeetingsModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public MeetingsModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        public List<Meeting> MeetingModel { get;set; } = default!;

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            if (_context.Meetings != null)
            {
                MeetingModel = await _context.Meetings.ToListAsync();
            }
        }
    }
}
