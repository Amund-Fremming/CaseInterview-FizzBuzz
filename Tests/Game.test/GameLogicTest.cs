using Xunit;
using Game;
using Interface;

public class GameLogicTest
{
    [Fact]
    public void ApplyRules_ReturnsResponse()
    {
        List<IRule> rules = new List<IRule> 
        { 
            new Rule(3, "Fizz"), 
            new Rule(5, "Buzz") 
        };
        GameLogic gameLogic = new GameLogic(rules);
        var result = gameLogic.ApplyRules(6); 

        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void ApplyRules_ReturnsNumber()
    {
        List<IRule> rules = new List<IRule> 
        { 
            new Rule(3, "Fizz"), 
            new Rule(5, "Buzz") 
        };
        GameLogic gameLogic = new GameLogic(rules);
        var result = gameLogic.ApplyRules(7);

        Assert.Equal("7", result);
    }

    [Fact]
    public void ApplyRules_EmptyList_ReturnsNumber()
    {
        List<IRule> rules = new List<IRule>();
        GameLogic gameLogic = new GameLogic(rules);
        var result = gameLogic.ApplyRules(7);

        Assert.Equal("7", result);
    }

    [Fact]
    public void Constructor_NoParams_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => new GameLogic(null!));
    }
}