var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello ");
    await next(context);

});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello2 ");
    await next(context);

});

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello3 ");
    await next(context);

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello Again");

});

app.Run();