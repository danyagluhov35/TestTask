using Microsoft.EntityFrameworkCore;
using MouseEvent.Infrastructure.Context;
using MouseEvent.IService;
using MouseEvent.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IMouseService, MouseService>();




var app = builder.Build();
app.UseStaticFiles();
app.UseDefaultFiles();


app.MapControllerRoute
    (
        name : "default",
        pattern : "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
