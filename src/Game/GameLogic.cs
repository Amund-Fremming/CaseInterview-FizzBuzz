using Interface;
using Configuration;

namespace Game;

public class GameLogic {

    private readonly Games Games;

    public GameLogic(Games games)
    {
        Games = Games ?? throw new ArgumentNullException(nameof(games));
    }

    private string ApplyRules(List<Rule> rules, int number)
    {
        string? output = null; 

        foreach(var rule in rules)
        {
            if(rule.DivisibleBy(number))
            {
                output += rule.OutputText;
            }
        }

        return output ?? number.ToString();
    }

    public void PlayGames()
    {
        foreach(GameRuleset game in Games.GameCollection)
        {
            IEnumerable<int> interval = Enumerable.Range(0, game.NumberOfIterations);
            if(game.Ascending) interval.Reverse();

            foreach(int number in interval)
            {
                ApplyRules(game.Rules, number);
            }
        }
    }
}