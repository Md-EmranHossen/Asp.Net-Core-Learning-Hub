var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("Files/{filename=sample}.{extension=text}", async context =>
    {
        string? fileName = context.Request.RouteValues["filename"]?.ToString() ?? "sample";
        string? extensionName = context.Request.RouteValues["extension"]?.ToString() ?? "text";
        await context.Response.WriteAsync($"IN - File {fileName} and {extensionName}");
    });

    endpoints.Map("Employee/Person/{Name=emran}", async context =>
    {
        string? personName = context.Request.RouteValues["Name"]?.ToString() ?? "emran";
        await context.Response.WriteAsync(personName);
    });

    endpoints.Map("product/details/{id=1}", async context =>
    {
        string? idValue = context.Request.RouteValues["id"]?.ToString();
        int productId = int.TryParse(idValue, out int parsedId) ? parsedId : 1;
        await context.Response.WriteAsync($"Product ID {productId}");
    });
});

// Default middleware for unmatched routes
app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();