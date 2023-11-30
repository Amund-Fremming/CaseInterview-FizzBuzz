using Game;

namespace Configuration;

public class GameRuleset
{
    public string Name { get; set; }
    public int NumberOfIterations { get; set; }
    public bool Ascending { get; set; }
    public List<Rule> Rules { get; set; } = new List<Rule>();
}