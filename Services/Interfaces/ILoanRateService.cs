// Services/Interfaces/ILoanRateService.cs
using LoanRatesAPI.Models;  // Add this line at the top

namespace LoanRatesAPI.Services.Interfaces;

public interface ILoanRateService
{
    LoanRate? GetLoanRate(LoanRateRequest request);
}