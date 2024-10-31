namespace SistemaDeTurnosPeluqueria.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public required decimal Importe { get; set; }
        public required DateTime DateTime { get; set; }
        public required string MetodoPago { get; set; }
        
        
    }
}
