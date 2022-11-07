using BookingAPI.DAL.DAS;
using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Services;
using BookingAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerDas, CustomerDas>();
builder.Services.AddScoped<IApartmentDas, ApartmentDas>();
builder.Services.AddScoped<IBookingDas, BookingDas>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IApartmentService, ApartmentService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IReviewDas,ReviewDas>();
builder.Services.AddScoped<IReviewService, ReviewService>();

builder.Services.AddDbContext<BookingAMContext>(option =>
                option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookingAM"));

builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
