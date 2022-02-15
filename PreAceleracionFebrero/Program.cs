using PreAceleracionFebrero.Contexts;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContext<DisneyContext>((services, options) =>
{
    options.UseInternalServiceProvider(services);
    options.UseSqlServer("Data Source=DESKTOP-UJVMHBA;Database=DisneyDb;Initial Catalog=NUEVA;Integrated Security=True;");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
