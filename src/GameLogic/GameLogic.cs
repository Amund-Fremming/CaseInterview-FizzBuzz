using System;
using Interface;
using GameLogic;

namespace GameLogic;

public class GameLogic : IGameLogic {

    private readonly List<Rule> _rules;

    public GameLogic(List<Rule> rules)
    {
        _rules = rules ?? throw new ArgumentNullException(nameof(rules));
    }

    public string ApplyRules(int number)
    {
        foreach(var rule in _rules)
        {
            if(rule.DivisibleBy(number))
            {
                return rule.Response;
            }
        }

        return number.ToString();
    }

}