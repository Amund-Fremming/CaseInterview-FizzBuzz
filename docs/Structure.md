# Structure

## Component definition

- **Game:** Contains the GameLogic.cs and Rule.cs files, which are central to the game's functionality. GameLogic.cs manages how the game operates, while Rule.cs specifies the individual rules that govern gameplay.
- **Configuration:** Comprises RulesConfigurator.cs and rules.json, responsible for reading the rules from the json file and creating a list of rules.
- **Interface:** Includes interfaces like IGameLogic.cs, IRule.cs, and IRulesConfigurator.cs, defining the contracts for various components of the application.
- **Tests:** Contains unit tests for validating the functionality of the game logic, rules, and their configuration.
- **Docs:** Provides documentation, including an overview, architecture and a detailed folder structure.

## Folder structure

```txt
FizzBuzzSolution/
│
├── src/
│   ├── Game/
│   │   ├── GameLogic.cs
│   │   └── Rule.cs
│   │
│   ├── Configuration/
│   │   ├── RulesConfigurator.cs
│   │   └── rules.json
│   │
│   ├── Interface/
│   │   ├── IGameLogic.cs
│   │   ├── IRule.cs
│   │   └── IRulesConfigurator.cs
│   │
│   └── Program.cs
│
├── Tests/
│   ├── Game.test/
│   │   ├── GameLogicTest.cs
│   │   └── RuleTest.cs
│   │
│   └── Configuration.test/
│       └── RulesConfiguratorTests.cs
│
├── Docs/
│   ├── Backend_overview.md
│   └── Folder_structure
│
└── .gitignore
```
