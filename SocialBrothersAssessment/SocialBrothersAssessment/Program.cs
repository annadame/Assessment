using Microsoft.EntityFrameworkCore;
using SocialBrothersAssessment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add connection to Sqlite database
var dbPath = Path.Join(Environment.CurrentDirectory, "addresses.db");
builder.Services.AddEntityFrameworkSqlite().AddDbContext<AddressDbContext>(options => { options.UseSqlite($"Data Source={dbPath}"); });

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
