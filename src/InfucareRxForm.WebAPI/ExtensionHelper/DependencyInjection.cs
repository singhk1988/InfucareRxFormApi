using FluentValidation.AspNetCore;
using InfucareRxForm.BusinessLayer.Abstractions;
using InfucareRxForm.BusinessLayer.Services;
using InfucareRxForm.DataLayer.Abstractions;
using InfucareRxForm.DataLayer.Repositories;
using InfucareRxForm.DataLayer.Services;

namespace InfucareRxForm.WebAPI.ExtensionHelper;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureDataLayerServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDapperDbConnection, DapperDbConnection>();
        serviceCollection.AddScoped<IPatientRepository, PatientRepository>();
        serviceCollection.AddScoped<IAssessmentRepository, AssessmentRepository>();
        serviceCollection.AddScoped<IFormResponseUrlRepository, FormResponseUrlRepository>();
        serviceCollection.AddFluentValidationAutoValidation();
        
        return serviceCollection;
    }
    
    public static IServiceCollection ConfigureBusinessServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IPatientService, PatientService>();
        serviceCollection.AddScoped<IAssessmentService, AssessmentService>();
        serviceCollection.AddScoped<IFormResponseUrlService, FormResponseUrlService>();
        serviceCollection.AddMvc();
       // serviceCollection.AddScoped<IValidator<PatientCreateRequestDto>, PatientCreateRequestDtoValidator>();
        
        return serviceCollection; 
    }
}