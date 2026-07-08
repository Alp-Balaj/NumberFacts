namespace NumberFacts.Api;

public record NumberFactsResult(int Number, bool IsEven, bool IsPrime, bool IsPerfectSquare);

public static class NumberFactsCalculator
{
    public static NumberFactsResult Calculate(int number) =>
        new(number, IsEven(number), IsPrime(number), IsPerfectSquare(number));

    private static bool IsEven(int number) => number % 2 == 0;

    private static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (var divisor = 2; (long)divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsPerfectSquare(int number)
    {
        if (number < 0)
        {
            return false;
        }

        var root = (int)Math.Sqrt(number);
        return root * root == number || (root + 1) * (root + 1) == number;
    }
}
