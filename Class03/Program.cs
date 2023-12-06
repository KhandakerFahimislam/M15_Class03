using Class03.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext <ProductDbContext>(op=> op.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("EnablesCORS",
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
            .AllowCredentials().Build();

        });
});
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
