using OData_Learning.Services.Abstract;
using OData_Learning.Services.Concrete;
using System.Runtime.CompilerServices;

namespace OData_Learning
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStudentService, StudentService>();
            return serviceCollection;
        }
    }
}
