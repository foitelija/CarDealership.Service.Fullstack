using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.CarDealership.BMW.Data;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly Web.CarDealership.BMW.Data.WebDB_Context _context;

        public IndexModel(WebDB_Context context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
