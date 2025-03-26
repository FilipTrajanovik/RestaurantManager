
using cafeManagement.Application.application.Implementation;
using cafeManagement.Application.application.Interfaces;
using cafeManagement.Repository;
using cafeManagement.Repository.Implementation;
using cafeManagement.Repository.Interfaces;
using cafeManagement.Service.domain.Implementation;
using cafeManagement.Service.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cafeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = "DefaultConnection";

            builder.Services.AddDbContext<ApplicationContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString(connectionString)));
            // Add services to the container.
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IAdminAppService, AdminAppService>();
            builder.Services.AddScoped<IAdminService, AdminService>();
            builder.Services.AddScoped<IAdminRepository, AdminRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
