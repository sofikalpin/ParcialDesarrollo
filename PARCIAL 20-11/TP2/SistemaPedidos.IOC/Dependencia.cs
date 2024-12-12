using SistemaPedidos.DAL.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SistemaPedidos.DAL.Repositorios.Contrato;
using SistemaPedidos.DAL.Repositorios;

namespace SistemaPedidos.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrdenesUsuarioContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("cadenaSQLServer");
                options.UseSqlServer(connectionString);
            });

            
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
