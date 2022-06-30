using HttpStatusCode.Infrastucture.Context;
using HttpStatusCode.Infrastucture.Repository.Abstract;
using HttpStatusCode.Infrastucture.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();

var constr = builder.Configuration.GetConnectionString("WebApiDb");

builder.Services.AddDbContext<SqlDbContext>(options =>
{
    options.UseSqlServer(constr);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
