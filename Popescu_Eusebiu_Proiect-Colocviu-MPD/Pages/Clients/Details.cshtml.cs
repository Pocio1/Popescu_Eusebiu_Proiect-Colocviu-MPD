using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.Data;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.List;

namespace Popescu_Eusebiu_Proiect_Colocviu_MPD.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext _context;

        public DetailsModel(Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext context)
        {
            _context = context;
        }

      public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Client == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            else 
            {
                Client = client;
            }
            return Page();
        }
    }
}
