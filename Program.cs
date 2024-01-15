using Microsoft.EntityFrameworkCore;
using NannoA_Student_Database.Data;
using NannoA_Student_Database.Services;
using NannoA_Student_Database.Services.Students;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//The first builder is accessing DbContext, the background data for our Database, and our Datacontext file to set the connection string
//The second builder is accesing our web apps configuration setting, or appsetting.json, and getting our connection string
//Letting our DataContext file know where our Database is
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DatabaseConnection"))
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentDataService, StudentDataService>();

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
