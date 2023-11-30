using Game;
using Configuration;
using Microsoft.Extensions.Configuration;

GameRuleset CreateGameRuleset(string rulesetKey) {
    var configuration = new ConfigurationBuilder()
        .AddJsonFile("Configuration/rules.json", optional: false, reloadOnChange: true)
        .Build();

    return configuration.GetSection(rulesetKey).Get<GameRuleset>() ?? throw new InvalidOperationException($"Configuration section {rulesetKey}");
}

void PlayGame(GameRuleset gameRuleset)
{
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
PlayGame(CreateGameRuleset("fizzbuzz"));

/* GAME 2 */
PlayGame(CreateGameRuleset("jazzfuzz"));

