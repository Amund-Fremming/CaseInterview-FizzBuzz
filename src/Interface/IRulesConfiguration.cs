using System;

namespace Interface;

/// <summary>
/// Takes in a config path and returns a list of rules.
/// </summary>
public interface IRulesConfiguration
{
    /// <summary>
    /// Takes in a path to a JSON config file and creates rules based on the config.
    /// <param name="configPath"></param>
    /// </summary>
    List<IRule> LoadRules(string configPath);
}