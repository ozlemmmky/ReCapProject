using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.EntitiyFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICarService,CarManager>();
builder.Services.AddSingleton<ICarDal, EfCarDal>();
builder.Services.AddSingleton<IColorService,ColorManager>();
builder.Services.AddSingleton<IColorDal, EfColorDal>();

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
