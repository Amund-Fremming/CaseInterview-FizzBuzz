using System;

namespace Interface;

/// <summary>
/// Defines the core logic for a game like FizzBuzz, applying rules to numbers.
/// </summary>
public interface IGameLogic {

    /// <summary>
    /// Applies the defined rules to a given number and returns the corresponding response.
    /// </summary>
    /// <param name="number">The number to which the rules will be applied.</param>
    /// <returns>The response string based on the rules applied to the number.</returns>
    public string ApplyRules(int number);

}