using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Test endpoint
app.MapGet("/", () => "Hello from .NET 8 Web API deployed using Docker!");

// Additional sample endpoint
app.MapGet("/info", () => new {
    App = "DotNet Docker Demo",
    Version = "1.0",
    Status = "Running Successfully"
});

app.Run();
