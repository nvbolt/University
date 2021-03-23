using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using University.DomainLayer.Repositories;
using University.DataLayer.Repositories;

namespace University.DataLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegistrationRepositories(this IServiceCollection collection)
        {
            collection.AddScoped<IGroupRepository, GroupRepository>();
            collection.AddScoped<IStudentRepository, StudentRepository>();
        }

        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<VuDbContext>(x => x.UseNpgsql(connectionString).UseSnakeCaseNamingConvention());
        }
    }
}
