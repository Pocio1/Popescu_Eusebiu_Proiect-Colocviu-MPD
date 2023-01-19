using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.Data;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.List;

namespace Popescu_Eusebiu_Proiect_Colocviu_MPD.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext _context;

        public EditModel(Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Client == null)
            {
                return NotFound();
            }

            var client =  await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            Client = client;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Client.ID))
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

        private bool ClientExists(int id)
        {
          return _context.Client.Any(e => e.ID == id);
        }
    }
}
