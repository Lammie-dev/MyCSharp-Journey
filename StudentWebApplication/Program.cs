using StudentWebApplicationAPI;
using StudentWebApplicationAPI.Data;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();



// Allow all for development
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
//to register EF core with SQLite
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=students.db"));


var app = builder.Build();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();