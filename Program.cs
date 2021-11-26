using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

Console.WriteLine($"AspNetCore location: {typeof(IWebHostBuilder).GetTypeInfo().Assembly.Location}");
Console.WriteLine($"AspNetCore version: {typeof(IWebHostBuilder).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");

Console.WriteLine($"NETCoreApp location: {typeof(object).GetTypeInfo().Assembly.Location}");
Console.WriteLine($"NETCoreApp version: {typeof(object).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");

app.Run();