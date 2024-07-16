namespace InfucareRxForm.WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>());

            IHost app = hostBuilder.Build();
            
            app.Run();
        }
        catch
        {
            
        }
        finally
        {
            
        }
    }
}
