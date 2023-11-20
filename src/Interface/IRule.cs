namespace Interface;

/// <summary>
/// Represents a rule in a numeric evaluation game like FizzBuzz.
/// A rule associates a divisor with a specific response string.
/// </summary>
public interface IRule
{
    int Divisor { get; }
    string OutputText { get; }

    /// <summary>
    /// Determines whether a given number is divisible by the rule's divisor.
    /// </summary>
    /// <param name="number">The number to test against the rule's divisor.</param>
    /// <returns>True if the number is divisible by the divisor; otherwise, false.</returns>
    bool DivisibleBy(int number);
}