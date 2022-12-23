using System.ComponentModel.DataAnnotations;

namespace PersonasAPI.Model
{
    public class NuevaPersonaDTO
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string? Nombre { get; set; }

        [Required]
        [FechaNacimientoValidation]
        public DateTime FechaNacimiento { get; set; }
    }
}
