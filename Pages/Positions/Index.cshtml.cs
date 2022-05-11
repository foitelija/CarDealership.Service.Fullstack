using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.CarDealership.BMW.Models;
    

namespace Web.CarDealership.BMW.Pages.Positions
{
    public class IndexModel : PageModel
    {
        private readonly Web.CarDealership.BMW.Data.WebDB_Context _context;
       
        public IndexModel(Web.CarDealership.BMW.Data.WebDB_Context context)
        {
            _context = context;
        }

        public IList<Position> Position { get; set; }

        public async Task OnGetAsync()
        {
            Position = await _context.Position.ToListAsync();
        }
    }
}
