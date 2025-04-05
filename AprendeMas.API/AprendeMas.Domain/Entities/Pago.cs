namespace AprendeMas.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; } // Tarjeta, PayPal, etc.
    }
}
