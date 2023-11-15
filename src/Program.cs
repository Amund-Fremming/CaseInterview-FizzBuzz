using Game;
using Interface;
using Configuration;


const string configPath = "./Configuration/rules.json";
IRulesConfigurator rulesConfigurator = new RulesConfigurator();

void PlayGame(string ruleset, int start, int end, int step)
{
    var rules = rulesConfigurator.LoadRules(configPath, ruleset);
    var gameLogic = new GameLogic(rules);

    for (int i = start; step > 0 ? i <= end : i >= end; i += step)
    {
        var response = gameLogic.ApplyRules(i);
        Console.WriteLine(response);
    }
}

/* GAME 1 */
PlayGame("ruleset1", 1, 100, 1);

/* GAME 2 */
PlayGame("ruleset2", 100, 1, -1);
