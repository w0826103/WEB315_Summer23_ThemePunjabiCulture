using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB315_Summer23_ThemePunjabiCulture.Models;

namespace WEB315_Summer23_ThemePunjabiCulture.Pages_PunjabiCulture
{
    public class DeleteModel : PageModel
    {
        private readonly PunjabiCultureContext _context;

        public DeleteModel(PunjabiCultureContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PunjabiCulture PunjabiCulture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PunjabiCulture = await _context.PunjabiCulture.FirstOrDefaultAsync(m => m.ID == id);

            if (PunjabiCulture == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PunjabiCulture = await _context.PunjabiCulture.FindAsync(id);

            if (PunjabiCulture != null)
            {
                _context.PunjabiCulture.Remove(PunjabiCulture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
