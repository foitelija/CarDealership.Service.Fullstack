using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.Autos
{
    public class CreateModel : PageModel
    {
        private readonly WebDB_Context _context;

        public CreateModel(WebDB_Context context)
        {
            _context = context;
        }


        public IActionResult OnGet()
        {
            ViewData["BTID"] = new SelectList(_context.Set<BodyType>(), "ID", "ID");
            ViewData["ManufID"] = new SelectList(_context.Manufactures, "ID", "ID");
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Auto Auto { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Auto.Add(Auto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
