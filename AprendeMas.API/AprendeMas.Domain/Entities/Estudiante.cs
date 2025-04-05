namespace AprendeMas.Domain.Entities
{
    public class Estudiante
    {
        public List<Curso> CursosInscritos { get; set; } = new();
        public List<Calificacion> Calificaciones { get; set; } = new();
    }
}
