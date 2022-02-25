
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSalesServices(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName )
        {
            services.AddRepositories(configuration,connectionStringName);
            services.AddUseCasesServices();
            services.AddPresenters();
            services.AddNorthWindSalesControllers();
            return services;
        }
    }
}
