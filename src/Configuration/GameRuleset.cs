using Game;

namespace Configuration;

public class GameRuleset
{
    public int NumberOfIterations { get; set; }
    public bool IsAscending { get; set; }
    public List<Rule> Rules { get; set; } = new List<Rule>();
}