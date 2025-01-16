var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", GetMe);

app.Run();


static string GetMe()
{
    return "Hello, World";
}