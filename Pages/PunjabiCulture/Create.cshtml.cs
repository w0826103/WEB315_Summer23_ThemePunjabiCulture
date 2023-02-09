using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB315_Summer23_ThemePunjabiCulture.Models;

namespace WEB315_Summer23_ThemePunjabiCulture.Pages_PunjabiCulture
{
    public class CreateModel : PageModel
    {
        private readonly PunjabiCultureContext _context;

        public CreateModel(PunjabiCultureContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PunjabiCulture PunjabiCulture { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PunjabiCulture.Add(PunjabiCulture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
