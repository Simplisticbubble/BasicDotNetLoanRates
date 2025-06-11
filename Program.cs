// Program.cs
using LoanRatesAPI.Services;
using LoanRatesAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to DI container
builder.Services.AddScoped<ILoanRateService, LoanRateService>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();