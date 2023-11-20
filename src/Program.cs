using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Game;
using System.Text.Json;
using Configuration;

void PlayGame(GameRuleset gameRuleset)
{
    GameLogic gameLogic = new GameLogic(gameRuleset.Rules);

    bool descendingInterval = gameRuleset.IntervalStart > gameRuleset.IntervalEnd ? true : false;

    IEnumerable<int> interval = Enumerable.Range(
        Math.Min(gameRuleset.IntervalStart, gameRuleset.IntervalEnd),
        Math.Abs(gameRuleset.IntervalEnd - gameRuleset.IntervalStart) + 1
    );

    if(descendingInterval)
        interval = interval.Reverse();

    foreach(int num in interval)
    {
        var outputText = gameLogic.ApplyRules(num);
        Console.WriteLine(outputText);
    }
}

GameRuleset CreateGameRuleset(string rulesetKey) {
    var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Configuration/rules.json", optional: false, reloadOnChange: true)
        .Build();

    return configuration.GetSection(rulesetKey).Get<GameRuleset>();
}

/* GAME 1 */
PlayGame(CreateGameRuleset("fizzbuzz"));

/* GAME 2 */
PlayGame(CreateGameRuleset("jazzfuzz"));

