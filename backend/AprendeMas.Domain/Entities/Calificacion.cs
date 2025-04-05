namespace AprendeMas.Domain.Entities
{
    public class Calificacion
    {
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public Curso Curso { get; set; }
        public double Nota { get; set; }
    }
}
