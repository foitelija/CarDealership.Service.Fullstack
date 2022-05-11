using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;


namespace Web.CarDealership.BMW.Pages.Manafacturs
{
    public class DetailsModel : PageModel
    {
        private readonly WebDB_Context _context;

        public DetailsModel(WebDB_Context context)
        {
            _context = context;
        }

        public Manufactures Manufactures { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufactures = await _context.Manufactures
                .Include(m => m.Staff).FirstOrDefaultAsync(m => m.ID == id);

            if (Manufactures == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
