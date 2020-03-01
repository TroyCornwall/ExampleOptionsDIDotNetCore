### Example Options loading and Dependency Injection in a DotNetCore console application

1. Add the following nuget packages

        Microsoft.Extensions.Configuration
        Microsoft.Extensions.Configuration.CommandLine
        Microsoft.Extensions.Configuration.EnvironmentVariables
        Microsoft.Extensions.Configuration.Json
        Microsoft.Extensions.DependencyInjection
        Microsoft.Extensions.Options
        Microsoft.Extensions.Options.ConfigurationExtensions
          
2. Add [Startup.cs](Startup.cs)  
   
3. Add appsettings.json and the class you would it bound to

    [appsettings.json](appsettings.json)

    [MyOptions](Options/MyOptions.cs)
    
    Make sure to mark appsettings.json as CopyToOutputDirectory = Always

 
4. Configure binding [Startup.cs](Startup.cs) Line 32

5. Add Services using Options

    [IExampleService.cs](Services/IExampleService.cs)

    [ExampleService.cs](Services/ExampleService.cs)

6. Add the service binding to DI [Startup.cs](Startup.cs) Line 14

7. Configure [Program.cs](Program.cs) to ConfigureServices, then pull a Service out of DI and then invoke it