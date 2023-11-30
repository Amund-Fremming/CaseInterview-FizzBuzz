using Game;
using Configuration;
using Microsoft.Extensions.Configuration;

Games CreateGameRuleset(string gameset) {
    var configuration = new ConfigurationBuilder()
        .AddJsonFile("Configuration/rules.json", optional: false, reloadOnChange: true)
        .Build();

    return configuration.GetSection(gameset).Get<Games>() ?? throw new InvalidOperationException($"Configuration section {gameset}");
}

void PlayGame(Games games)
{
    GameLogic gameLogic = new GameLogic(games);
    gameLogic.PlayGames();
}

var ruleset = CreateGameRuleset("gameset");
Console.WriteLine(ruleset.GameCollection.Count());

PlayGame(ruleset);


