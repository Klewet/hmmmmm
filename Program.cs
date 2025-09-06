var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from ASP.NET Core CI/CD on Azure VM!");

app.Run();
