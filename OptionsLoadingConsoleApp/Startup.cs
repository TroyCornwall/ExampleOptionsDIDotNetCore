using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OptionsLoadingConsoleApp
{
    public class Startup
    {
        public static ServiceProvider ConfigureServices(IServiceCollection services, string[] args)
        {
            //Add IConfigRoot so that you can uses options while setting up DI
            var options = ConfigureOptions(services, args);
            
            services.AddTransient<IExampleService, ExampleService>();
            
            return services.BuildServiceProvider();
        }

        private static IConfigurationRoot ConfigureOptions(IServiceCollection services, string[] args)
        {
            //This means we first load from appsettings.json 
            //Then override with env vars if they exist
            //Then override with command line args if they exist
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .AddCommandLine(args);

            var config = configBuilder.Build();
            //Bind to object, add to DI
            services.Configure<MyOptions>(config);
            return config;
        }
    }
}