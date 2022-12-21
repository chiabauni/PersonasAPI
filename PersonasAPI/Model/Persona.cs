using System.ComponentModel.DataAnnotations;

namespace PersonasAPI.Model
{
    public class Persona
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression (@"^[a-zA-Z]+$")]
        public string? Nombre { get; set; }

        [Required]
        [FechaNacimientoValidation]
        public DateTime FechaNacimiento { get; set; }

        public string? Categoria { get; set; }
    }
}
