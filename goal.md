# Goal: NumberFacts endpoint

Repo: NumberFacts.Api (ASP.NET Core minimal API), tests in NumberFacts.Tests (xUnit).

Add a single GET endpoint `/numberfacts/{n}` (n: int) returning JSON:
{ "number": n, "isEven": bool, "isPrime": bool, "isPerfectSquare": bool }

Exactly one checkpoint, as small as possible.

Exclusions: no persistence, no external API calls, no auth, no other endpoints.

Acceptance criteria (each must be checkable from the diff plus green gates alone):
1. GET /numberfacts/4 returns isEven=true, isPrime=false, isPerfectSquare=true
2. GET /numberfacts/7 returns isEven=false, isPrime=true, isPerfectSquare=false
3. Unit tests cover at least one even, one odd-prime, and one perfect-square case
4. `dotnet build` and `dotnet test` both exit 0