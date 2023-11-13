using System;
using Configuration;
using Game;
using Interface;

public class Program
{
    static void Main(string[] args)
    {
        string configPath = "./Configuration/rules.json";
        
        RulesConfiguration rulesConfiguration = new RulesConfiguration();
        List<IRule> rules = rulesConfiguration.LoadRules(configPath);

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
