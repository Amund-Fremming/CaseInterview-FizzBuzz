using Interface;

namespace Game;

public record Rule(int Divisor, string OutputText) : IRule
{
    public bool DivisibleBy(int number) => number % Divisor == 0;
}