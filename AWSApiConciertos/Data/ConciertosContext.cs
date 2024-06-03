using AWSApiConciertos.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSApiConciertos.Data
{
    public class ConciertosContext : DbContext
    {
        public ConciertosContext(DbContextOptions<ConciertosContext> options) : base(options) { }

        public DbSet<CategoriaEvento> CategoriasEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}
