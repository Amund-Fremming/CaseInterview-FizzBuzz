using System;

namespace Interface;

/// <summary>
/// Defines the gamelogic for FizzBuzz.
/// Takes in a number and returnes the response based on the rules applied. 
/// </summary>
public interface IGameLogic {

    /// <summary>
    /// <param name="number">The Intger for appling the rules to.</param>
    /// </summary>
    public string ApplyRules(int number);

}