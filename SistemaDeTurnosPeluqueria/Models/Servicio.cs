namespace SistemaDeTurnosPeluqueria.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public decimal Price { get; set; }
    }
}
