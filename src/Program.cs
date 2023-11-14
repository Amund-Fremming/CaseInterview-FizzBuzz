using Game;
using Interface;
using Configuration;

public class Program
{
    static void Main(string[] args)
    {
        const string configPath = "./Configuration/rules.json";

        /* GAME ONE */
        IRulesConfigurator rulesConfigurator = new Configuration.RulesConfigurator();
        
        List<IRule> gameOneRules = rulesConfigurator.LoadRules(configPath, "ruleset1");
        GameLogic gameOneLogic = new GameLogic(gameOneRules);

        for(int i = 1; i <= 100; i++)
        {
            string response = gameOneLogic.ApplyRules(i);
            Console.WriteLine(response);
        }

        /* GAME TWO */
        List<IRule> gameTwoRules = rulesConfigurator.LoadRules(configPath, "ruleset2");
        GameLogic gameTwoLogic = new GameLogic(gameTwoRules);
   
        for(int i = 100; i > 0; i--)
        {
            string response = gameTwoLogic.ApplyRules(i);
            Console.WriteLine(response);
        }
    }
}
