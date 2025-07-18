var builder = WebApplication.CreateBuilder(args);
builder.Services.AddConnections();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
