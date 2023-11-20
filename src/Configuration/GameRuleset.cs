using Game;
using Microsoft.Extensions.Configuration;

namespace Configuration;

class GameRuleset
{
    public int IntervalStart { get; set; }
    public int IntervalEnd { get; set; }
    public List<Rule> Rules { get; set; } = new List<Rule>();

    public GameRuleset CreateGameRuleset(string rulesetKey) {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Configuration/rules.json", optional: false, reloadOnChange: true)
            .Build();

        return configuration.GetSection(rulesetKey).Get<GameRuleset>();
    }
}