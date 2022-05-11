using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.Manafacturs
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Context _context;

        public IndexModel(WebDB_Context context)
        {
            _context = context;
        }

        public IList<Manufactures> Manufactures { get; set; }

        public async Task OnGetAsync()
        {
            Manufactures = await _context.Manufactures
                .Include(m => m.Staff).ToListAsync();
        }
    }
}
