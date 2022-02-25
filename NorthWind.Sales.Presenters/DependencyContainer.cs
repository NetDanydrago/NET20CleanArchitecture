
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CreateOrderPresenter>();
            services.AddScoped<ICreateOrderPresenter, CreateOrderPresenter>(
                provider => provider.GetService<CreateOrderPresenter>());
            services.AddScoped<ICreateOrderOutputPort, CreateOrderPresenter>(
                provider =>  provider.GetService<CreateOrderPresenter>());
            return services;
        }
    }
}
