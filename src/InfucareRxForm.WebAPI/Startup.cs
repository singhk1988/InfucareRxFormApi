using System.Reflection;
using FluentValidation.AspNetCore;
using InfucareRxForm.WebAPI.ExtensionHelper;

namespace InfucareRxForm.WebAPI;

public class Startup
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddControllers();
        serviceCollection.AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

       // serviceCollection.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
        serviceCollection.AddEndpointsApiExplorer();
        serviceCollection.AddSwaggerGen();
        serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        
        serviceCollection
            .ConfigureDataLayerServices()
            .ConfigureBusinessServices();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        
        // Configure the HTTP request pipeline.
        if (!environment.IsProduction())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(configure => configure.MapControllers());
    }
}