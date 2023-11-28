using RealTimeData.BusinessLayer.Abstract;
using RealTimeData.BusinessLayer.Concrete;
using RealTimeData.DataAccessLayer.Abstract;
using RealTimeData.DataAccessLayer.Concrete;
using RealTimeData.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RealTimeDataContext>();

builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IAboutDal,EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();

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
