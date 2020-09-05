using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estetica.Models
{
    public class Province
    {
        [Key]
        public int IdProvince { get; set; }
        [Display(Name = "País")]
        public int? IdCountry { get; set; }
        [Display(Name = "Provincia")]
        public string ProvinceName { get; set; }
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es correcto.")]
        [Display(Name = "Fecha de Registro")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? RegistrationDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "El formato de fecha no es correcto.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de baja")]
        public DateTime? Lowdate { get; set; }
        [Display(Name = "Estado")]
        public bool? Status { get; set; }
        [Display(Name = "País")]

        //Propiedad de navegación. Con virtual se crea la carga Perezosa
        public virtual ICollection<Country> Countries { get; set; }
    }
}
