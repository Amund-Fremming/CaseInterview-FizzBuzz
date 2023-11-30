using System;
using Game;
using Configuration;
using Microsoft.Extensions.Configuration;

namespace Util;

static class RulsetUtil {

    public static GameRuleset CreateGameRuleset(string rulesetKey) {
    var configuration = new ConfigurationBuilder()
        .AddJsonFile("Configuration/rules.json", optional: false, reloadOnChange: true)
        .Build();

    return configuration.GetSection(rulesetKey).Get<GameRuleset>() ?? throw new InvalidOperationException($"Configuration section {rulesetKey}");
}

}