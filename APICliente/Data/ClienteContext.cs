using APICliente.Models;
using Microsoft.EntityFrameworkCore;

namespace APICliente.Data
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }
        public ClienteContext(DbContextOptions<ClienteContext> opt)
           : base(opt)
        {

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ClienteContext>(
                options => options.UseSqlServer("server=localhost;database=filmedb;user=Sa;password=Sk89840551."));
        }
    }
}
