using LoanRatesAPI.Models;

namespace LoanRatesAPI.Services.Interfaces;

public interface ILoanRateService
{
    LoanRate? GetLoanRate(LoanRateRequest request);
}