using Interface;

namespace Game;

public class GameLogic : IGameLogic {

    private readonly List<IRule> _rules;

    public GameLogic(List<IRule> rules)
    {
        _rules = rules ?? new List<IRule>();
    }

    public string ApplyRules(int number)
    {
        foreach(var rule in _rules)
        {
            if(rule.DivisibleBy(number))
            {
                return rule.OutputText;
            }
        }

        return number.ToString();
    }

}