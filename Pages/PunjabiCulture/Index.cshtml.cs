using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList LocalCulture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Diversity { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> CultureNameQuery = from c in _context.PunjabiCulture
                                    orderby c.CultureName
                                    select c.CultureName;

            var Celebration = from c in _context.PunjabiCulture
                        select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Celebration = Celebration.Where(s => s.CultureName.Contains(SearchString) || s.OriginCity.Contains(SearchString) || s.OrganisedBy.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(Diversity))
            {
                Celebration = Celebration.Where(x => x.CultureName == Diversity);
            }
            LocalCulture = new SelectList(await CultureNameQuery.Distinct().ToListAsync());
            PunjabiCulture = await Celebration.ToListAsync();
        }
    }
}
