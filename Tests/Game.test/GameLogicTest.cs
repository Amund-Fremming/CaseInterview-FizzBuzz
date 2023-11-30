using Xunit;
using Game;
using Configuration;

public class GameLogicTest
{
    [Fact]
    public void ApplyRules_ReturnsResponse()
    {
        List<Rule> rules = new List<Rule> 
        { 
            new Rule(3, "Fizz"), 
            new Rule(5, "Buzz") 
        };

        GameRuleset gameRuleset = new GameRuleset();
        gameRuleset.Rules = rules;

        GameLogic gameLogic = new GameLogic(gameRuleset.Rules);
        var result = gameLogic.ApplyRules(6); 

        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void ApplyRules_ReturnsNumber()
    {
        List<Rule> rules = new List<Rule> 
        { 
            new Rule(3, "Fizz"), 
            new Rule(5, "Buzz") 
        };

        GameRuleset gameRuleset = new GameRuleset();
        gameRuleset.Rules = rules;

        GameLogic gameLogic = new GameLogic(gameRuleset.Rules);
        var result = gameLogic.ApplyRules(7);

        Assert.Equal("7", result);
    }

    [Fact]
    public void ApplyRules_EmptyList_ReturnsNumber()
    {
        List<Rule> rules = new List<Rule>();
        GameLogic gameLogic = new GameLogic(rules);
        var result = gameLogic.ApplyRules(7);

        Assert.Equal("7", result);
    }
}