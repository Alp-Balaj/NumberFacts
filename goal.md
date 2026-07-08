# Goal: Swagger UI for interactive testing

Repo: NumberFacts.Api (ASP.NET Core minimal API), tests in NumberFacts.Tests (xUnit).
The API already exposes an OpenAPI document via `AddOpenApi()`/`MapOpenApi()` (route `/openapi/v1.json`
in Development), and a `GET /numberfacts/{n}` endpoint returning JSON:
{ "number": n, "isEven": bool, "isPrime": bool, "isPerfectSquare": bool }

Add a browsable Swagger UI, available only in Development, that renders the existing OpenAPI
document so a human can browse and invoke `/numberfacts/{n}` (and `/weatherforecast`) from a browser.

Exactly one checkpoint, as small as possible.

Exclusions: no auth, no persistence, no external API calls, no changes to existing endpoint
behavior/contracts, no exposure outside Development.

Acceptance criteria (each must be checkable from the diff plus green gates alone):
1. In Development, GET /swagger returns 200 with the Swagger UI HTML page
2. The Swagger UI is wired to the existing OpenAPI document (`/openapi/v1.json`) and lists both
   `/numberfacts/{n}` and `/weatherforecast`
3. Swagger UI is not registered when `app.Environment.IsDevelopment()` is false
4. `dotnet build` and `dotnet test` both exit 0