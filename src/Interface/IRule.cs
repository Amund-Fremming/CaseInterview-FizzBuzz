using System;

namespace Interface;

/// <summary>
/// Defines a rule for determing if a number meets a certain condition
/// Produces a string as output for the number if the condition is met
/// </summary>
public interface IRule
{
    /// <summary>
    /// Returns true if the given number matches the methods condition (Rule).
    /// </summary>
    /// <param name="number">The Integer for testing if the condition is met</param>
    /// <returns>
    bool DivisibleBy(int number);
    
    /// <summary>
    /// Produces a string as output for the rule.
    /// Made for returning a string when the DivisibleBy condition is met.
    /// </summary>
    /// <returns> A string as output for the rule
    
    /* string GetResponse(); */
}