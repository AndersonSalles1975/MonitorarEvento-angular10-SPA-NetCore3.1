using Domain.Interfaces.Services;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Crosscutting.DependencyInjection
{
	public class ConfigureService
	{
		public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<IEventoService, EventoService>();
		}
	}
}
