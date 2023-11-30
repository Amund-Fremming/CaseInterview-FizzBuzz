using Interface;
using Configuration;

namespace Game;

public class GameLogic {

    private readonly GameRuleset GameRuleset;

    public GameLogic(GameRuleset gameRuleset)
    {
        GameRuleset = gameRuleset ?? throw new NullReferenceException(nameof(gameRuleset));
        
    }

    public string ApplyRules(int number)
    {

        string? output = null; 

        foreach(var rule in GameRuleset.Rules)
        {
            if(rule.DivisibleBy(number))
            {
                output += rule.OutputText;
            }
        }

        return output ?? number.ToString();
    }

    private IEnumerable<int> CreateInterval()
    {
        IEnumerable<int> interval = Enumerable.Range(0, GameRuleset.NumberOfIterations);

        if(!GameRuleset.IsAscending) interval.Reverse();

        return interval;
    }

    public void PlayGame()
    {
        IEnumerable<int> interval = CreateInterval();
        
        foreach(int number in interval)
        {
            string output = ApplyRules(number);
            Console.WriteLine(output);
        }
    }
}