
using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.BusinessLayer.Services;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Repositories;
using InfucareRxForm.DataLayer.Services;
using System.Reflection;

namespace InfucareRxForm.WebAPI
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
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            builder.Services.AddScoped<IDapperDbConnection, DapperDbConnection>();
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IAssessmentRepository, AssessmentRepository>();
            builder.Services.AddScoped<IAssessmentService, AssessmentService>();            
            builder.Services.AddScoped<IFormResponseUrlRepository, FormResponseUrlRepository>();
            builder.Services.AddScoped<IFormResponseUrlService, FormResponseUrlService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
