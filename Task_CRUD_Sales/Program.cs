using Microsoft.EntityFrameworkCore;
using Task_CRUD_Sales.Models;
using Task_CRUD_Sales.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
});

builder.Services.AddCors(op =>
{
    op.AddPolicy("registerCORS", po =>
    {
        po.AllowAnyMethod();
        po.AllowAnyHeader();
        po.AllowAnyOrigin();
    });
});

builder.Services.AddScoped<IClientRepo, ClientRepo>();
builder.Services.AddScoped<ISalesRepo,Sales_Repo >();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("registerCORS");
app.MapControllers();

app.Run();
