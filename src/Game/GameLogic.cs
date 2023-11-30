using Interface;

namespace Game;

public class GameLogic : IGameLogic {

    private readonly List<Rule> _rules;

    public GameLogic(List<Rule> rules)
    {
        _rules = rules ?? new List<Rule>();
    }

    public string ApplyRules(int number)
    {

        string? output = null; 

        foreach(var rule in _rules)
        {
            if(rule.DivisibleBy(number))
            {
                output += rule.OutputText;
            }
        }

        return output ?? number.ToString();
    }
}