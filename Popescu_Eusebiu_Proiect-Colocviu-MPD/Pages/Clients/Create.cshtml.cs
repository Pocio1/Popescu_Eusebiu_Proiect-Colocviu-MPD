using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.Data;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.List;

namespace Popescu_Eusebiu_Proiect_Colocviu_MPD.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext _context;

        public CreateModel(Popescu_Eusebiu_Proiect_Colocviu_MPD.Data.Popescu_Eusebiu_Proiect_Colocviu_MPDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
