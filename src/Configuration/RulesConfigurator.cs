using Interface;
using Newtonsoft.Json.Linq;
using Game;

namespace Configuration;

public class RulesConfigurator : IRulesConfigurator
{
    public List<IRule> LoadRules(string configPath, string ruleset) {
        List<IRule> rules = new List<IRule>();
        
        try
        {
            string jsonString = File.ReadAllText(configPath);

            JObject jObject = JObject.Parse(jsonString);
            JArray rulesArray = (JArray)jObject[ruleset];
            
            foreach(JObject rule in rulesArray)
            {
                int divisor = rule.Value<int>("divisor");
                string response = rule.Value<string>("response");
                rules.Add(new Rule(divisor, response));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error loading rules: " + e.Message);
        }

        return rules;
    }
}
