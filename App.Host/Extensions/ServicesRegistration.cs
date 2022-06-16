using AppHost.AutoMap;
using AppServices.Services;
using AppServices.Services.Abstract;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AppHost.Extensions
{
    public static class ServicesRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IDetailService, DetailService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IMapper>(service => new Mapper(MapperConfig.GetConfiguration()));
        }
    }
}
