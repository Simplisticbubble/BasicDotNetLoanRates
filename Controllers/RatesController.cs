using LoanRatesAPI.Models;
using LoanRatesAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoanRatesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RatesController : ControllerBase
{
    private readonly ILoanRateService _loanRateService;

    // Dependency injection
    public RatesController(ILoanRateService loanRateService)
    {
        _loanRateService = loanRateService;
    }

    [HttpGet]
    public IActionResult GetRate([FromQuery] string loanType, [FromQuery] int term)
    {
        // Validate input
        if (string.IsNullOrEmpty(loanType) )
            return BadRequest("Loan type is required");
        
        if (term <= 0)
            return BadRequest("Term must be positive");

        // Process request
        var request = new LoanRateRequest(loanType, term);
        var rate = _loanRateService.GetLoanRate(request);

        // Return response
        return rate == null 
            ? NotFound("No rate found for specified criteria") 
            : Ok(rate);
    }
}