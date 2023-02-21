using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WEB315_Summer23_ThemePunjabiCulture.Models
{
    public static class SeedData_PunjabiCulture
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PunjabiCultureContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PunjabiCultureContext>>()))
            {
                
                if (context.PunjabiCulture.Any())
                {
                    return;   // DB has been seeded
                }
                else
                {
                    context.PunjabiCulture.AddRange(
                        new PunjabiCulture
                        {
                            CultureName = "Diwali",
                        OccassionDate = DateTime.Parse("2023-11-12"),
                        Costume = "jeans",
                        Food = "dal roti",
                        OrganisedBy = "gurbinder",
                        DaysOfCelebration = 7,
                        OriginCity = "Amritsar"
                        },

                        new PunjabiCulture
                        {
                            CultureName = "Holi",
                        OccassionDate = DateTime.Parse("2023-04-12"),
                        Costume = "kurta pajama",
                        Food = "saag",
                        OrganisedBy = "manpreet",
                        DaysOfCelebration = 1,
                        OriginCity = "Ayodhya"
                        },

                        new PunjabiCulture
                        {
                            CultureName = "new year",
                        OccassionDate = DateTime.Parse("2023-01-01"),
                        Costume = " suit",
                        Food = " dhee",
                        OrganisedBy = "karam",
                        DaysOfCelebration = 2,
                        OriginCity = "Kolkata"
                        },

                        new PunjabiCulture
                        {
                            CultureName = "dusshera",
                        OccassionDate = DateTime.Parse("2023-10-12"),
                        Costume = "tehmat",
                        Food = "paneer",
                        OrganisedBy = "harry",
                        DaysOfCelebration = 10,
                        OriginCity = "Ayodhya"
                        },

                        new PunjabiCulture
                        {
                            CultureName = "vaisakhi",
                        OccassionDate = DateTime.Parse("2023-04-14"),
                        Costume = "phulkari",
                        Food = "mix veg",
                        OrganisedBy = "meenu",
                        DaysOfCelebration = 1,
                        OriginCity = "Anandpur Sahib"
                        }
                    );
                    context.SaveChanges();
                }
                
            }
        }
    }
}
