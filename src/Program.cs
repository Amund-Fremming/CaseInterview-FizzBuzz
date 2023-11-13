using Game;
using Interface;
using Configuration;

public class Program
{
    static void Main(string[] args)
    {
        string configPath = "./Configuration/rules.json";
        
        IRulesConfigurator rulesConfigurator = new Configuration.RulesConfigurator();
        List<IRule> rules = rulesConfigurator.LoadRules(configPath);

        GameLogic gameLogic = new GameLogic(rules);

        for(int i = 1; i <= 100; i++)
        {
            string response = gameLogic.ApplyRules(i);
            Console.WriteLine(response);
        }

        for(int i = 100; i > 0; i--)
        {
            string response = gameLogic.ApplyRules(i);
            Console.WriteLine(response);
        }

    }
}
