using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        private readonly WebDB_Context _context;

        public DetailsModel(WebDB_Context context)
        {
            _context = context;
        }

        public Customers Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers
                .Include(c => c.Auto)
                .Include(c => c.Staff).FirstOrDefaultAsync(m => m.ID == id);

            if (Customers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
