using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.AEs
{
    public class DetailsModel : PageModel
    {
        public readonly WebDB_Context _context;

        public DetailsModel(WebDB_Context context)
        {
            _context = context;
        }

        public AdditionalEquipment AdditionalEquipment { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdditionalEquipment = await _context.AdditionalEquipment.FirstOrDefaultAsync(m => m.ID == id);

            if (AdditionalEquipment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
