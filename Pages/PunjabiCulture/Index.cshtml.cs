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
    public class IndexModel : PageModel
    {
        private readonly PunjabiCultureContext _context;

        public IndexModel(PunjabiCultureContext context)
        {
            _context = context;
        }

        public IList<PunjabiCulture> PunjabiCulture { get;set; }

        public async Task OnGetAsync()
        {
            PunjabiCulture = await _context.PunjabiCulture.ToListAsync();
        }
    }
}
