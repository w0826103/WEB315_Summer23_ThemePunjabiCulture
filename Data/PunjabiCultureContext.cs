using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB315_Summer23_ThemePunjabiCulture.Models;

    public class PunjabiCultureContext : DbContext
    {
        public PunjabiCultureContext (DbContextOptions<PunjabiCultureContext> options)
            : base(options)
        {
        }

        public DbSet<WEB315_Summer23_ThemePunjabiCulture.Models.PunjabiCulture> PunjabiCulture { get; set; }
    }
