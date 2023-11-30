using Game;
using Configuration;
using Util;

GameRuleset rules1 = RulsetUtil.CreateGameRuleset("fizzbuzz");
GameLogic gl1 = new GameLogic(rules1);
gl1.PlayGame();

GameRuleset rules2 = RulsetUtil.CreateGameRuleset("jazzfuzz");
GameLogic gl2 = new GameLogic(rules2);
gl2.PlayGame();

