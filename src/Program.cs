using Game;
using Interface;
using Configuration;

const string configPath = "./Configuration/rules.json";
IRulesConfigurator rulesConfigurator = new RulesConfigurator();

void PlayGame(string ruleset, int min, int max, bool forward)
{
    var rules = rulesConfigurator.LoadRules(configPath, ruleset);
    var gameLogic = new GameLogic(rules);

    IEnumerable<int> interval = Enumerable.Range(min, max);

    if(!forward)
        interval = interval.Reverse();
    
    foreach(int num in interval)
    {
        var response = gameLogic.ApplyRules(num);
        Console.WriteLine(response);
    }
}

// GAME 1
PlayGame("ruleset1", 1, 100, true);

// GAME 2
PlayGame("ruleset2", 1, 100, false);

/*
int min = 1;
int max = 100;
bool forward = false;

IEnumerable<int> nums = Enumerable.Range(min, max);

if(!forward)
    nums = nums.Reverse();

foreach(var i in nums)
{
    Console.WriteLine(i);
}
*/