var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/test", () => "Это тест");

app.MapGet("/param", async context =>
{
    await context.Response.WriteAsync("Это строка параметров:"
          + context.Request.QueryString.ToString());
});

app.MapGet("/html", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<h1>Привет</h1> Мир!"
          + context.Request.QueryString.ToString());
});

app.MapGet("/func", HomePage);


app.Run();

async Task HomePage(HttpContext context)
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("Привет из функции!");
}
