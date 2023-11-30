using Xunit;
using Game;
using Interface;

public class RuleTest
{
    [Theory]
    [InlineData(9, 3, true)]
    [InlineData(8, 3, false)]
    public void DivisibleBy_ReturnsExpected(int number, int divisor, bool expectedResult) {
        IRule rule = new Rule(divisor, "Test");
        bool actualResult = rule.DivisibleBy(number);

        Assert.Equal(expectedResult, actualResult);
    }
    
}