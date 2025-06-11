// Models/LoanRateRequest.cs
namespace LoanRatesAPI.Models;

// Simple DTO for request parameters
public record LoanRateRequest(
    string LoanType,  // "owner-occupied", "investment", etc.
    int Term          // Loan term in years (e.g., 30, 15)
);