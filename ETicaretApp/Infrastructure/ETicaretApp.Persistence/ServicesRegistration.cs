using ETicaretApp.Application.Interfaces.Repositories.ProductRepo;
using ETicaretApp.Persistence.Context;
using ETicaretApp.Persistence.Repositories.ProductRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApp.Persistence
{
    public static class ServicesRegistration
    {
        
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //Service Lifetimes - Servislerin yaşam süreleri
            //AddSingleton, AddScoped, AddTransient
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ETicaretAppDBContext>(options => options.UseSqlServer(Settings.ConnString));
        }
    }
}
