
using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer23_ThemePunjabiCulture.Models
{
    public class PunjabiCulture
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Culture Name is required.")]
        [Display(Name ="Culture Name")]
        [StringLength(40, MinimumLength = 3)]
        public string CultureName { get; set; }

        [Required(ErrorMessage = "Celebration Date is required.")]
        [Display(Name ="Occassion Date")]
        [DataType(DataType.Date)]
        public DateTime OccassionDate { get; set; }

        [Required(ErrorMessage = "Costume Name is required.")]
        [StringLength(40, MinimumLength = 3)]
        public string Costume { get; set; }

        [Required(ErrorMessage = "Food Name is required.")]
        [StringLength(40, MinimumLength = 3)]
        public string Food { get; set; }

        [Required(ErrorMessage = "Organisor's Name is required.")]
        [Display(Name ="Organised By")]
        [StringLength(40, MinimumLength = 3)]
        public string OrganisedBy { get; set; }

        [Range(1, 15)]
        [Required(ErrorMessage = "No. of Celebration Days is required.")]
        [Display(Name ="No. Of Days Celebrated")]
        public int DaysOfCelebration { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "First letter must be uppercase, no special characters or numbers allowed")]
        [Required(ErrorMessage = "Origin City Name is required.")]
        [Display(Name ="Origin City Name")]
        [StringLength(40, MinimumLength = 3)]
        public string OriginCity { get; set; }
    }
}
