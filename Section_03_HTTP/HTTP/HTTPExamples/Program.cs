using Microsoft.Extensions.Primitives;
using System.IO;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    StreamReader reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();
    Dictionary<string, StringValues> qeruyDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

    if (qeruyDict.ContainsKey("firstName"))
    {
        string firstName = qeruyDict["firstName"][0];
        await context.Response.WriteAsync(firstName);
    }
});
app.Run();
