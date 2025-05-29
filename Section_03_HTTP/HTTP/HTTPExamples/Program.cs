var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    context.Response.Headers["Emran"] = "text/html";
    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        string agent = context.Request.Headers["Emran"];
        await context.Response.WriteAsync($"<p> {agent} </p>");
    }
});
app.Run();
