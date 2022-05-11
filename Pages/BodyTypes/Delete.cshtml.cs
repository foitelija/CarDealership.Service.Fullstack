using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Models;
using Web.CarDealership.BMW.Data;

namespace Web.CarDealership.BMW.Pages.BodyTypes
{
    public class DeleteModel : PageModel
    {
        private readonly WebDB_Context _context;

        public DeleteModel(WebDB_Context context)
        {
            _context = context;
        }


        [BindProperty]
        public BodyType BodyType { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BodyType = await _context.BodyType.FirstOrDefaultAsync(m => m.ID == id);

            if (BodyType == null)
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

            BodyType = await _context.BodyType.FindAsync(id);

            if (BodyType != null)
            {
                _context.BodyType.Remove(BodyType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
