using Microsoft.EntityFrameworkCore;
using OData_Learning.DAL;
using OData_Learning.Services.Abstract;
using OData_Learning.Services.Concrete;
using System.Runtime.CompilerServices;

namespace OData_Learning
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection,IConfiguration configuration)
        {

            serviceCollection.AddDbContext<ApplicationDbContext>(opt => 
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
         
            serviceCollection.AddScoped<IStudentService, StudentService>();
            serviceCollection.AddScoped<IGradeService, GradeService>();
            return serviceCollection;
        }
    }
}
