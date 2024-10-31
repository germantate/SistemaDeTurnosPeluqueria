namespace SistemaDeTurnosPeluqueria.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }
        public int IdPeluquero { get; set; }
        public Peluquero? Peluquero { get; set; }
        public int IdServicio { get; set; }
        public Servicio? Servicio { get; set; }
        public int EstadoId {  get; set; }
        public Estado? Estado { get; set; }        
    }
}
