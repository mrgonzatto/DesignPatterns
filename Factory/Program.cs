using Factory.FactoryMethod.Enemies;
using Factory.FactoryMethod.Levels;

// Using the factory method design pattern
Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
level1.EncounterEnemy();

Level level2 = LevelFactory.CreateLevel(levelNumber: 2);
level2.EncounterEnemy();

// Not using the factory method design pattern
Goblin concreteProduct = new Goblin();