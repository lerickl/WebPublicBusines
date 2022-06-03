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
builder.Services.AddScoped<ICloudinaryService, CloudinaryService>();
builder.Services.AddScoped<IImagenService, ImagenService>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IServicioService, ServicioService>();
builder.Services.AddScoped<IValidacionesService, ValidarService>();
builder.Services.AddScoped<ICategoriaEmpresa, CategoriaEmpresaService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddMvc();
//builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
     
    options.IdleTimeout = TimeSpan.FromMinutes(10);
  
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
//
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
