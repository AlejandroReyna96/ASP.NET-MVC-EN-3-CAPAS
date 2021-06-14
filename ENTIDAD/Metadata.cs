using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class DepartamentoMetadata
    {

        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        [Display(Name = "Nombre del Departamento")]
        public string NombreDepartamento { get; set; }
    }


}
