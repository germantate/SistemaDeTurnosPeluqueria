namespace SistemaDeTurnosPeluqueria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int Dni {  get; set; }
        public required string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string? Email {  get; set; }
    }
}
