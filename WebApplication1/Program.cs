using Microsoft.EntityFrameworkCore;
using WebApplication1.DataDb;
using WebApplication1.Servicios;
using WebApplication1.Servicios.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebeOContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 
builder.Services.AddScoped<IEmpresaService, EmpresaService>();

builder.Services.AddSession(options => 
{
    options.Cookie.Name = ".AdventureWarks.Session";
    options.IOTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.IsEssential = true;

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
