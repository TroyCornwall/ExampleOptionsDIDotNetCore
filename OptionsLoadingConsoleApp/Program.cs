using System;
using Microsoft.Extensions.DependencyInjection;

namespace OptionsLoadingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Startup.ConfigureServices(new ServiceCollection(), args);
            var exampleService = serviceProvider.GetService<IExampleService>();
            exampleService.Run();
        }
    }
}