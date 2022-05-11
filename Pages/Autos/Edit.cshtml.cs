using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Models;
using Web.CarDealership.BMW.Data;

namespace Web.CarDealership.BMW.Pages.Autos
{
    public class EditModel : PageModel
    {
        private readonly WebDB_Context _context;

        public EditModel(WebDB_Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Auto Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auto = await _context.Auto
                .Include(a => a.BT)
                .Include(a => a.Manuf)
                .Include(a => a.Staff).FirstOrDefaultAsync(m => m.ID == id);

            if (Auto == null)
            {
                return NotFound();
            }
            ViewData["BTID"] = new SelectList(_context.Set<BodyType>(), "ID", "ID");
            ViewData["ManufID"] = new SelectList(_context.Manufactures, "ID", "ID");
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

            _context.Attach(Auto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(Auto.ID))
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

        private bool AutoExists(long id)
        {
            return _context.Auto.Any(e => e.ID == id);
        }
    }
}
