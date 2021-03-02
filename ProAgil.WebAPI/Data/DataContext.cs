using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Evento> Eventos { get; set; }  // Usado para criar um Banco de dados, nesse caso o "Eventos" é o nome da tabela e o DB recebe o Evento( está em model)

    }
}