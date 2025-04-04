using AprendeMas.Domain.Enum;

namespace AprendeMas.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public RolEnums Rol { get; set; }
        public string Password { get; set; }
    }
}
