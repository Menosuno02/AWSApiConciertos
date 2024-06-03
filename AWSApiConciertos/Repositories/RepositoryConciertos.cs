using AWSApiConciertos.Data;
using AWSApiConciertos.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSApiConciertos.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }

        public async Task<List<CategoriaEvento>> GetCategoriasEventosAsync()
        {
            return await this.context.CategoriasEventos.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosCategoriaAsync(int idCategoria)
        {
            return await this.context.Eventos
                .Where(e => e.IdCategoria == idCategoria)
                .ToListAsync();
        }
    }
}
