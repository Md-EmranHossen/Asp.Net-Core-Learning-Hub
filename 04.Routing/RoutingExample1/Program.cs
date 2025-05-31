var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// eanable routing
app.UseRouting();

// creating endpoints
app.UseEndpoints(endpoints =>
{

});



app.Run();
