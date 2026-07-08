using NumberFacts.Api;

namespace NumberFacts.Tests;

public class NumberFactsCalculatorTests
{
    [Fact]
    public void Calculate_EvenNumber_ReturnsExpectedFacts()
    {
        var result = NumberFactsCalculator.Calculate(4);

        Assert.Equal(4, result.Number);
        Assert.True(result.IsEven);
        Assert.False(result.IsPrime);
        Assert.True(result.IsPerfectSquare);
    }

    [Fact]
    public void Calculate_OddPrimeNumber_ReturnsExpectedFacts()
    {
        var result = NumberFactsCalculator.Calculate(7);

        Assert.Equal(7, result.Number);
        Assert.False(result.IsEven);
        Assert.True(result.IsPrime);
        Assert.False(result.IsPerfectSquare);
    }

    [Fact]
    public void Calculate_PerfectSquareNumber_ReturnsExpectedFacts()
    {
        var result = NumberFactsCalculator.Calculate(9);

        Assert.Equal(9, result.Number);
        Assert.False(result.IsEven);
        Assert.False(result.IsPrime);
        Assert.True(result.IsPerfectSquare);
    }
}
