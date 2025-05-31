var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
    {
        await context.Response.WriteAsync($"Endpoint:{endPoint.DisplayName}\n");
    }
    await next(context);
});


app.UseRouting();


app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
    {
        await context.Response.WriteAsync($"Endpoint:{endPoint.DisplayName}\n");
    }
    await next(context);
});


app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("map1", async (context) =>
    {
        await context.Response.WriteAsync("Im Map 1");
    });

    endpoints.MapPost("map2", async (context) =>
    {
        await context.Response.WriteAsync("Im Map 2");
    });
});

app.Run(async (context) =>
{
    context.Response.WriteAsync("Default");
});

app.Run();
