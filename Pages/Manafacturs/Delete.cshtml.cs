using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models; 

namespace Web.CarDealership.BMW.Pages.Manafacturs
{
    public class DeleteModel : PageModel
    {

        private readonly WebDB_Context _context;

        public DeleteModel(WebDB_Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufactures = await _context.Manufactures.FindAsync(id);

            if (Manufactures != null)
            {
                _context.Manufactures.Remove(Manufactures);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
