using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Context _context;

        public IndexModel(WebDB_Context context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers
                .Include(c=>c.Auto)
                .Include(c=>c.Staff)
                .ToListAsync();
        }
    }
}
