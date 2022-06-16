using AppServices.DTOs;
using AppServices.Vlidators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AppHost.Extensions
{
    public static class ValidatorsRegistration
    {
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddSingleton<IValidator<FullEmployeeDTO>, FullEmployeeDTOValidator>();
            services.AddSingleton<IValidator<ShortEmployeeDTO>, ShortEmployeeDTOValidator>();
            services.AddSingleton<IValidator<CreateDetailDTO>, CreateDetailDTOValidator>();
            services.AddSingleton<IValidator<UpdateDetailDTO>, UpdateDetailDTOValidator>();
        }
    }
}
