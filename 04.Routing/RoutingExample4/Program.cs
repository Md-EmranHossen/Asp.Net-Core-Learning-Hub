var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}",
        async context =>
        {
            string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
            string? extensionName = Convert.ToString(context.Request.RouteValues["extension"]);

            await context.Response.WriteAsync($"In files -{fileName} - {extensionName}");
        });

    endpoints.Map("employee/profile/{name}", async context =>
    {
        string? EmployeeName = Convert.ToString(context.Request.RouteValues["name"]);
        await context.Response.WriteAsync($"In file{EmployeeName}");
    });

});

app.Run(async context =>
{
    context.Response.WriteAsync($"Request Received at{context.Request.Path}");
});


app.Run();
