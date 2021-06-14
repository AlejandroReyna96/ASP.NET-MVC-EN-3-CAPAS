using System.ComponentModel.DataAnnotations;

namespace ENTIDAD
{
    public class DepartamentoMetadata
    { 
        [Required]
        [MinLength(3)]
        [MaxLength(150)]
        [Display(Name = "Nombre del Departamentoo")]
        public string NombreDepartamento { get; set; }
    }
}
