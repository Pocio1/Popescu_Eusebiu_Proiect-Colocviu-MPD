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
    public class IndexModel : PageModel
    {
        private readonly Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext _context;

        public IndexModel(Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Client != null)
            {
                Client = await _context.Client.ToListAsync();
            }
        }
    }
}
