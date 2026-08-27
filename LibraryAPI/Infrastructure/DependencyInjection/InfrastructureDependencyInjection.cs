using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;
using LibraryAPI.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Infrastructure.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure dbContext
            var connectionString = configuration.GetConnectionString("LibraryConnection");
            services.AddDbContext<LibraryDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Configure repositories
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            return services;
        }
    }
}
