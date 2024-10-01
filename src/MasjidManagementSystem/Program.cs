using MasjidManagementSystem.CustomMiddleware;
using MasjidManagementSystem.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<MyCustomMiddlewareClass>();
builder.Services.AddDbContext<MasjidDbContext>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("MasjidDbContextCS")));

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

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

////middleware 1
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Hello World from Middleware 1");
//    await next(context);

//});
////middleware 2
//app.UseMiddleware<MyCustomMiddlewareClass>();
////middleware 3
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Hello World from 3");

//});

//Enable Routing
//app.UseRouting();

//Creating Endpoints
//app.UseEndpoints(endpoint =>
//{
//    endpoint.Map("files/{file}.{extention}", async (HttpContext context) =>
//    {
//        string fileName = Convert.ToString(context.Request.RouteValues["file"]);
//        string extention = Convert.ToString(context.Request.RouteValues["extention"]);
//        await context.Response.WriteAsync($"IN files --> {fileName} --> {extention}");
//    });

//    endpoint.Map("products/files/{id=1}", async (HttpContext context) =>
//    {
//        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
//        await context.Response.WriteAsync($"Its id is ---> {id}");
//    });
//});

//app.Run();
