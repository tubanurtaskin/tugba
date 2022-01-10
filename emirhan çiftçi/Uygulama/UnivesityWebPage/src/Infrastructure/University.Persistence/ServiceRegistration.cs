using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using University.Application.Interfaces.Repositories;
using University.Persistence.Context;
using University.Persistence.Repositories;
using University.Persistence.Services;

namespace University.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionStr = configuration.GetConnectionString("UniversityDbConnectionString");

            services.AddDbContext<UniversityDbContext>(opt =>
            {
                opt.UseSqlServer(connectionStr);
                opt.EnableSensitiveDataLogging();
            });

            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ILinkRepository, LinkRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<IIdentityService, IdentityService>();

            var optionsBuilder = new DbContextOptionsBuilder<UniversityDbContext>()
                .UseSqlServer(connectionStr);

            using var dbContext = new UniversityDbContext(optionsBuilder.Options, null);
            dbContext.Database.EnsureCreated();
            dbContext.Database.Migrate();

            return services;
        }
    }
}
