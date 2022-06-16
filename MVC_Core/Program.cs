var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name:"default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
