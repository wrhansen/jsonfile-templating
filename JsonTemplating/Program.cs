using DotLiquid.FileSystems;
using DotLiquid;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

Template.FileSystem = new LocalFileSystem(Path.Combine(Directory.GetCurrentDirectory(), "Schemas", "Templates"));

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
