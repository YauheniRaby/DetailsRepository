using AppData.Repositories.Abstract;
using AppData.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AppHost.Extensions
{
    public static class RepositoriesRegistration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IDetailRepository, DetailRepository>();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
