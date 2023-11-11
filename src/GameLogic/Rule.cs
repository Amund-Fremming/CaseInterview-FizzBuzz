using System;
using Interface;

namespace GameLogic;

public class Rule : IRule {

    public int Divisor { get; set; }
    public string Response { get; set; }

    public Rule(int divisor, string response) {
        this.Divisor = divisor;
        this.Response = response ?? throw new ArgumentNullException(nameof(response));
    }

    public bool DivisibleBy(int number) {
        return number % Divisor == 0;
    }

}