using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estetica.Models
{
    public class Town
    {
        [Key]
        public int IdTown { get; set; }
        public int? IdProvince { get; set; }
        public string TownName { get; set; }
        public bool? Status { get; set; }

        //Propiedad de navegación. Con virtual se crea la carga Perezosa
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
