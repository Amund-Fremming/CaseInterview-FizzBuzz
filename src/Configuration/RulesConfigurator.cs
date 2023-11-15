using Interface;
using Game;
using Newtonsoft.Json.Linq;

namespace Configuration;

public class RulesConfigurator : IRulesConfigurator
{
    public List<IRule> LoadRules(string configPath, string ruleset) 
    {
        var rules = new List<IRule>();
        
        try {
            string jsonString = File.ReadAllText(configPath);
            var jObject = JObject.Parse(jsonString);

            if (jObject[ruleset] is JArray rulesArray)
            {
                foreach(var rule in rulesArray.OfType<JObject>())
                {
                    var divisor = rule.Value<int>("divisor");
                    var response = rule.Value<string>("response")!;
                    rules.Add(new Rule(divisor, response));
                }
            }
        } catch (JsonReaderException e) {
            Console.WriteLine($"JSON error: {e.Message}");
        } catch (IOException e) {
            Console.WriteLine($"File read error: {e.Message}");
        }

        return rules;
    }
}
