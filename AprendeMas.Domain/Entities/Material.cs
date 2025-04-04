namespace AprendeMas.Domain.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public Curso Curso { get; set; }
    }
}
