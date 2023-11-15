using Interface;

namespace Game;

public class Rule : IRule {

    public int Divisor { get; set; }
    public string Response { get; set; }

    public Rule(int divisor, string response) {
        this.Divisor = divisor;
        this.Response = response;
    }

    public bool DivisibleBy(int number) => number % Divisor == 0;

}