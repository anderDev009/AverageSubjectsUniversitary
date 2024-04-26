
using AvgUniversitary.Core.Application.Interfaces.Services;
using AvgUniversitary.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AvgUniversitary.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {

            #region Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion
            #region Services
            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<IUniversityService, UniversityService>();
            #endregion

        }
    }
}
