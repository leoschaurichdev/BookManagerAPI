using BookManager.API.Persistence;
using BookManager.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IConfigService, ConfigService>();

//builder.Services.AddDbContext<BookManagerDbContext>(o => o.UseInMemoryDatabase("BookManagerDB"));

var connectionString = builder.Configuration.GetConnectionString("BookManagerDB");

builder.Services.AddDbContext<BookManagerDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();