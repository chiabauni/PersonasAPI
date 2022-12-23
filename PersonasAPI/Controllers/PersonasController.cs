using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonasAPI.Infrastructure.Db;
using PersonasAPI.Model;

namespace PersonasAPI.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly Context _context;

        public PersonasController(Context context)
        {
            _context = context;
        }

        // GET: api/personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersona()
        {
            return await _context.Persona.ToListAsync();
        }

        // POST: api/personas
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(NuevaPersonaDTO nuevaPersona)
        {
            Console.WriteLine(nuevaPersona);
            Console.WriteLine(Convert.ToDateTime(nuevaPersona.FechaNacimiento));
            var persona = new Persona()
            {
                Nombre = nuevaPersona.Nombre,
                FechaNacimiento = nuevaPersona.FechaNacimiento
            };
            _context.Persona.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.Id }, persona);
        }
    }
}
