using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CongApp.Data;
using CongApp.Models;

namespace CongApp.Pages.Admin.User
{
    public class IndexModel : PageModel
    {
        private readonly CongApp.Data.CongAppDbContext _context;

        public IndexModel(CongApp.Data.CongAppDbContext context)
        {
            _context = context;
        }

        public IList<Assignee> Assignee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Assignee != null)
            {
                Assignee = await _context.Assignee.ToListAsync();
            }
        }
    }
}
