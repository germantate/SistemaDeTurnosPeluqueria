using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SistemaDeTurnosPeluqueria.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {
        }

        
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Peluquero> Peluqueros { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        
    }
}
