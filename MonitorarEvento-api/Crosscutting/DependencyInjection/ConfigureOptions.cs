using Domain.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crosscutting.DependencyInjection
{
    public class ConfigureOptions
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<ConfigurationsOptions>(configuration.GetSection("Configurations"));
        }
    }
}
