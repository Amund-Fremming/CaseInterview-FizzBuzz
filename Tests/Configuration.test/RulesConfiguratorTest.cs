using Xunit;
using Interface;
using Configuration;

public class RulesConfiguratorTest
{
    [Fact]
    public void LoadRules_NonExistingRuleset()
    {
        IRulesConfigurator configurator = new RulesConfigurator();
        List<IRule> rules = configurator.LoadRules("./../../../../src/Configuration/rules.json", "ruleset1000");

        Assert.Empty(rules);
    }

    [Fact]
    public void LoadRules_ReturnsListWith3Rules()
    {
        RulesConfigurator configurator = new RulesConfigurator();
        List<IRule> rules = configurator.LoadRules("./../../../../src/Configuration/rules.json", "ruleset1");

        Assert.Equal(3, rules.Count);
    }
}