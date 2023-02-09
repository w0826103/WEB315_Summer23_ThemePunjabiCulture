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
    public class DetailsModel : PageModel
    {
        private readonly PunjabiCultureContext _context;

        public DetailsModel(PunjabiCultureContext context)
        {
            _context = context;
        }

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
    }
}
