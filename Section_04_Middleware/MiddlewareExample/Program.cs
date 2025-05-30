var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsJsonAsync("Hello Again");

});

app.Run();
