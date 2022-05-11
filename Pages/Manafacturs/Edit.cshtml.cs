using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;


namespace Web.CarDealership.BMW.Pages.Manafacturs
{
    public class EditModel : PageModel
    {

        private readonly WebDB_Context _context;

        public EditModel(WebDB_Context context)
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
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Manufactures).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturersExists(Manufactures.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ManufacturersExists(long id)
        {
            return _context.Manufactures.Any(e => e.ID == id);
        }
    }
}
