var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    context.Response.Headers["Server"] = "My Server";
    context.Response.Headers["Mykey"] = "My value";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h1> Hello World </h1>");
});

app.Run();
