using EmployeeManagement.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<MongoDbContext>();

// ✅ เพิ่ม Swagger API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee Management API",
        Version = "v1",
        Description = "An API for managing employees in a MongoDB database."
    });
});

var app = builder.Build();

// ✅ เปิด Swagger UI ในทุกสภาพแวดล้อม
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee Management API V1");
        c.RoutePrefix = "swagger";  // Swagger UI เปิดที่ `/swagger`
    });
}

// ✅ กำหนดลำดับ Middleware ให้ถูกต้อง
app.UseStaticFiles(); // 📌 ต้องมาก่อน Routing
app.UseRouting();
app.UseAuthorization();
// ✅ API Routing (EmployeeApiController)
app.MapControllers();  

// ✅ MVC Routing (EmployeeController)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();