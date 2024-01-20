using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly PersonaContext _context;

        public PersonasController(PersonaContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult>CrearPersona(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Persona>>> ListaPersonas()
        {
            var personas = await _context.Personas.ToListAsync();

            return Ok(personas);
        }

        [HttpGet]
        [Route("ver")]
        public async Task<IActionResult>VerPersonas(int id)
        {
            Persona persona = await _context.Personas.FindAsync(id);

            if(persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult>ActualizarPersona(int id, Persona persona)
        {
            var personaExistente = await _context.Personas.FindAsync(id);

            personaExistente!.Nombre = persona.Nombre;
            personaExistente.Telefono = persona.Telefono;
            personaExistente.Direccion = persona.Direccion;
            personaExistente!.Email = persona.Email;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult>EliminarPersona(int id)
        {
            var personaBorrada = await _context.Personas.FindAsync(id);
            _context.Personas.Remove(personaBorrada!);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
