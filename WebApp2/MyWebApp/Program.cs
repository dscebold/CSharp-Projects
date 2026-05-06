using Microsoft.AspNetCore.Rewrite;
using MyWebApp.Interfaces;
using MyWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IWelcomeService, WelcomeService>();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("Hello from middleware 1. Passing to the next middleware!\r\n");
//
//     await next.Invoke();
//
//     await context.Response.WriteAsync("Hello from middleware 1 again!\r\n");
// });
//
// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Hello from middleware 2!\r\n");
// });

app.Use(async (context, next) =>
{
    await next();
    
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
});

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

// app.MapGet("/", () => "Welcome to My Web App!");
app.MapGet("/", (IWelcomeService welcomeService1, IWelcomeService welcomeService2) =>
{
    string message1 = $"Message1: {welcomeService1.GetWelcomeMessage()}";
    string message2 = $"Message2: {welcomeService2.GetWelcomeMessage()}";
    return $"{message1}\n{message2}";
});
app.MapGet("/about", () => "My Web App was made in 2026.");

app.Run();

