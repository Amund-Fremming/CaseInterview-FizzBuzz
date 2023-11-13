using System;
using Interface;
using Newtonsoft.Json.Linq;
using Game;

namespace Configuration;

public class RulesConfiguration
{
    public List<IRule> LoadRules(string configPath) {
        List<IRule> _rules = new List<IRule>();
        string jsonString = File.ReadAllText(configPath);

        JObject jObject = JObject.Parse(jsonString);
        JArray rulesArray = (JArray)jObject["rules"];
        
        foreach(JObject rule in rulesArray)
        {
            int divisor = rule.Value<int>("divisor");
            string response = rule.Value<string>("response");
            _rules.Add(new Rule(divisor, response));
        }

        return _rules;
    }
}
