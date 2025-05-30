using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();

var app = builder.Build();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("From Middleware 1");
    await next(context);

});

// middleware 2
app.UseMiddleware<MyCustomMiddleware>();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("From Middleware 3");
    await next(context);

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("From Middleware 4");

});

app.Run();