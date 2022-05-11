using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Models;
using Web.CarDealership.BMW.Data;
namespace Web.CarDealership.BMW.Pages.Autos
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Context _context;
        public IndexModel(WebDB_Context context)
        {
            _context = context;
        }
        public IList<Auto> Auto { get; set; }

        public async Task OnGetAsync()
        {
            Auto = await _context.Auto
                .Include(a => a.BT)
                .Include(a => a.Manuf)
                .Include(a => a.Staff).ToListAsync();
        }
    }
}
