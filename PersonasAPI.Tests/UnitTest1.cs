
using FakeItEasy;
using PersonasAPI.Application.Controllers;
using PersonasAPI.Model;

namespace PersonasAPI.Tests
{
    public class PersonasControllerTests
    {
        [Fact]
        public void Post_Persona_Mayor_De_80_Devulve_Octogenaria()
        {
            Persona testPersona = new Persona()
            {
                Nombre = "Laura",
                FechaNacimiento = new DateTime(1920, 05, 21)
            };

        }
    }
}