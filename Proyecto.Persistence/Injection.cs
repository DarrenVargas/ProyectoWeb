using Guests.Application.Contracts.Contexts;
using Guests.Application.Contracts.Repositories;
using Guests.Domain.EntityModels.Guests;
using Guests.Persistence.Contexts;
using Guests.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Guests.Persistence
{
    public static class Injection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());

            services.AddRepository<Guest, IGuestRepository, GuestRepository>();

            return services;
        }
    }
}
