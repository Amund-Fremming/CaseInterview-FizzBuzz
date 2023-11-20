using Game;
using Configuration;

void PlayGame(string rulesetKey)
{
    GameRuleset gameRuleset = new GameRuleset().CreateGameRuleset(rulesetKey);
    GameLogic gameLogic = new GameLogic(gameRuleset.Rules);

    IEnumerable<int> interval = Enumerable.Range(
        Math.Min(gameRuleset.IntervalStart, gameRuleset.IntervalEnd),
        Math.Abs(gameRuleset.IntervalEnd - gameRuleset.IntervalStart) + 1
    );

    bool descendingInterval = gameRuleset.IntervalStart > gameRuleset.IntervalEnd ? true : false;

    if(descendingInterval)
        interval = interval.Reverse();

    foreach(int num in interval)
    {
        var outputText = gameLogic.ApplyRules(num);
        Console.WriteLine(outputText);
    }
}

/* GAME 1 */
PlayGame("fizzbuzz");

/* GAME 2 */
PlayGame("jazzfuzz");

