# Loan Rates API

A minimal .NET Core Web API that provides mock loan rate data. Using .Net 8

### GET /api/rates

Returns loan rate information based on parameters.

**Parameters:**

- `loanType` (required): Type of loan (e.g., "owner-occupied", "investment")
- `term` (required): Loan term in years (e.g., 30, 15)

**Example Request:**

GET: http://localhost:5000/api/rates?loanType=owner-occupied&term=30
