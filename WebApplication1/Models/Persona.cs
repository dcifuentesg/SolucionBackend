using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int Telefono { get; set; }

        public string Direccion { get; set; }

        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set;}
    }
}
