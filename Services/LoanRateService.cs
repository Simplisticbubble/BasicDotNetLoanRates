// Services/LoanRateService.cs
using LoanRatesAPI.Models;  // Add this line at the top
using LoanRatesAPI.Services.Interfaces;  // And this one

namespace LoanRatesAPI.Services;

public class LoanRateService : ILoanRateService
{
    private readonly List<LoanRate> _mockRates = new()
    {
        new("owner-occupied", 30, 3.25m, DateTime.UtcNow),
        new("owner-occupied", 15, 2.75m, DateTime.UtcNow),
        new("investment", 30, 3.75m, DateTime.UtcNow),
        new("investment", 15, 3.25m, DateTime.UtcNow)
    };

    public LoanRate? GetLoanRate(LoanRateRequest request)
    {
        return _mockRates.FirstOrDefault(r => 
            r.LoanType == request.LoanType && 
            r.Term == request.Term);
    }
}