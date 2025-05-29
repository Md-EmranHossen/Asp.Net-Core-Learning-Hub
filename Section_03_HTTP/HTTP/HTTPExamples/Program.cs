var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    if (1 == 1)
    {
        context.Response.StatusCode = 302;
    }
    else
    {
        context.Response.StatusCode = 500;
    }

    await context.Response.WriteAsync("Hello World");


});

app.Run();
