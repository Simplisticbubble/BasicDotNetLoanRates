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
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/api/rates?loanType=owner-occupied&term=30");
        return;
    }
    await next();
});
app.Run();