using TaskManagerAPI.Core.Configurations;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Infrastructure.Repositories;
using TaskManagerAPI.Insfrastructure.Configurations;


namespace TaskManagerAPI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCoreServices();
            builder.Services.AddInsfrastructureServices();

            builder.Services.AddScoped<IBaseRepository<User>, UserRepository>();

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