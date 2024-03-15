using ManageAcademyWeb.Repository;
using ManageAcademyWeb.Repository.Repository;
using ManageAcademyWeb.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace ManageAcademyWeb.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<DataBaseContext>(options =>
            {
                options.UseNpgsql(config.GetConnectionString("WebApiDatabase"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Sistema de Gest�o de Academia Web",
                    Description = "Sistema de Gest�o de Academia",
                });
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: "development",
                                  policy =>
                                  {
                                      policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200");
                                  });
            });

            return services;
        }
    }
}