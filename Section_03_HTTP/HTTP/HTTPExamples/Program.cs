var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    string path = context.Request.Path;
    string methodName = context.Request.Method;

    context.Response.Headers["Content-type"] = "text/html";
    await context.Response.WriteAsync($"<p> {path} </p>");
    await context.Response.WriteAsync($"<p> {methodName} </p>");

});

app.Run();
