using FluentValidation;
using Guests.Application.Contracts;
using Guests.Application.Diagnostics;
using Guests.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Guests.Application
{
    public static class Injection
    {
        public static IServiceCollection AddAplication
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Guard>(options => { });

            var assembly = typeof(Injection).Assembly;

            services.AddMediatR(options => options.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IGuestService, GuestService>();

            return services;
        }
    }
}
