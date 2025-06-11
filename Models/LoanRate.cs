// Models/LoanRate.cs
namespace LoanRatesAPI.Models;

public record LoanRate(
    string LoanType,
    int Term,
    decimal InterestRate,
    DateTime LastUpdated
);