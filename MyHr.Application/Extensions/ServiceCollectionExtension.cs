using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using MyHr.Application.Mappings;
using MyHr.Application.Services;
using MyHr.Application.Validators;

namespace MyHr.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddAutoMapper(typeof(EmployeeMappingProfile));

            services.AddValidatorsFromAssemblyContaining<EmployeeDtoValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
