
using AccountManagementWebApp.BusinessLayer.Abstract;
using AccountManagementWebApp.BusinessLayer.Concrete;
using AccountManagementWebApp.Core.Mapping;
using AccountManagementWebApp.DataAccessLayer.Abstract;
using AccountManagementWebApp.DataAccessLayer.Concrete;
using AccountManagementWebApp.DataAccessLayer.EntityFramework;

namespace AccountManagementWebApp.WebApi
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

            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<IEmployeeDAL, EfEmployeeDAL>();
            builder.Services.AddScoped<IEmployeeService, EmployeeManager>();

            builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("ApiCors", opts =>
                {
                    opts.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("ApiCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
