using Game;

namespace Configuration;

public class GameRuleset
{
    public int IntervalStart { get; set; }
    public int IntervalEnd { get; set; }
    public List<Rule> Rules { get; set; } = new List<Rule>();
}