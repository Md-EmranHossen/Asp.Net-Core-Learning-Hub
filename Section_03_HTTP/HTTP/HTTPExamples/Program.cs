var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    context.Response.Headers["Content-type"] = "text/html";
    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        string agent = context.Request.Headers["User-Agent"];
        await context.Response.WriteAsync($"<p> {agent} </p>");
    }
});
app.Run();
