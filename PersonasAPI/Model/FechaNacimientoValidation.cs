using System.ComponentModel.DataAnnotations;

namespace PersonasAPI.Model
{
    public class FechaNacimientoValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var persona = validationContext.ObjectInstance as Persona;
            if (persona?.FechaNacimiento.GetType() != typeof(DateTime))
            {
                return new ValidationResult("El formato de la fecha no es el correcto");
            }
            var edad = DateTime.Now.Year - persona?.FechaNacimiento.Year;
            var yaCumplioAnios = DateTime.Now.Month > persona?.FechaNacimiento.Month;
            if (!yaCumplioAnios)
            {
                edad -= 1;
            }
            if (edad < 18)
            {
                return new ValidationResult("Solo se permite dar de alta mayores de 18 años");
            }
            return ValidationResult.Success;
        }
    }
}