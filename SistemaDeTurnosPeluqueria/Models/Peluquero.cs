namespace SistemaDeTurnosPeluqueria.Models
{
    public class Peluquero
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int Dni { get; set; }
        public string? Domicilio { get; set; }
        public int Telefono { get; set; }
    }
}
