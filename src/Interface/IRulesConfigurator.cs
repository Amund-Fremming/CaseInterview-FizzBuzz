namespace Interface;

/// <summary>
/// Provides functionality to load game rules from a configuration source.
/// </summary>
public interface IRulesConfigurator
{
    /// <summary>
    /// Loads rules from a specified JSON configuration file.
    /// </summary>
    /// <param name="configPath">The file path to the JSON configuration file.</param>
    /// <param name="ruleset">Specifies the name of the ruleset to be used</param>
    /// <returns>A list of IRule objects constructed from the configuration file.</returns>
    List<IRule> LoadRules(string configPath, string ruleset);
}