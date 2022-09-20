using ExpenseApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(x => {
    string ConnectionKey = "Dev";

#if RELEASE
    ConnectionKey = "Prod";
#endif 

    x.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionKey));
});

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => {
    x.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
});

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services
            .GetRequiredService<IServiceScopeFactory>()
            .CreateScope();
scope.ServiceProvider
    .GetService<AppDbContext>()!
    .Database.Migrate();

app.Run();
