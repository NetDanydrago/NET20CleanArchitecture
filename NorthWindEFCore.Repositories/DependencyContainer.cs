using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<NorthWindSalesContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            services.AddScoped<INorthWindSalesCommandsRepository, NorthWindSalesCommandsRepository>();
            return services;
        }
    }
}
