
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Universitary.Infrastructure.Persistence.Context;
using Universitary.Infrastructure.Persistence.Repositories;

namespace Universitary.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureLayer(this IServiceCollection services,IConfiguration configuration)
        {
            #region Context
            services.AddDbContext<UniversitaryAvgContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("default"),optionsSql =>
                {
                    optionsSql.MigrationsAssembly(typeof(UniversitaryAvgContext).Assembly.FullName);
                });
            });
            #endregion
            #region Services
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IUniversityRepository, UniversityRepository>();
            #endregion
        }
    }
}
