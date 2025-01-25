using CodingLanguages.Web.Services;
using CodingLanguages.Web.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddHttpClient<ILanguageService, LanguageService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ServiceUrls:CodingLanguagesApi"]);
});

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
