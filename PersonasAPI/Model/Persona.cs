using System.ComponentModel.DataAnnotations;

namespace PersonasAPI.Model
{
    public class Persona
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }
        
        public DateTime FechaNacimiento { get; set; }

        public string? Categoria { get; set; }
    }
}
