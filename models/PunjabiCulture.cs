
using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer23_ThemePunjabiCulture.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string CultureName { get; set; }

        [DataType(DataType.Date)]
        public DateTime OccassionDate { get; set; }
        public string Costume { get; set; }
        public string Food { get; set; }
        public string OrganisedBy { get; set; }

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}
