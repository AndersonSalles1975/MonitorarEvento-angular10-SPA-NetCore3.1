using Data.Context;
using Data.Implementations;
using Data.Repository;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crosscutting.DependencyInjection
{
	public class ConfigureRepository {
        public static void ConfigureDependenciesRepository (IServiceCollection serviceCollection, IConfiguration configuration) {
            serviceCollection.AddScoped(typeof (IRepository<>), typeof (BaseRepository<>));
            serviceCollection.AddScoped<IEventoRepository, EventoImplementation>();

            //SQLSERVER
            serviceCollection.AddDbContext<MyContext> (
                options => options.UseSqlServer(configuration.GetSection("Configurations")["ConnectionString"])
            );
        }
    }
}
