using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estetica.ViewModel
{
    public class CountryViewModel
    {
        [Key]
        [Display(Name = "Id País")]
        public int IdCountry { get; set; }
        [Required(ErrorMessage = "Ingrese nombre del país")]
        [Display(Name = "País")]
        public string CountryName { get; set; }
        [Display(Name = "Estado")]
        public bool? Status { get; set; }
    }
}
