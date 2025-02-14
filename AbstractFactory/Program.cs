using AbstractFactory.CaveLevel;
using AbstractFactory.Common;
using AbstractFactory.HauntedHouseLevel;

void SetupEnvironment(LevelElementFactory levelFactory)
{ 
    var enemy = levelFactory.CreateEnemy();
    var weapon = levelFactory.CreateWeapon();
    var powerUp = levelFactory.CreatePowerUp();

    //..
}

SetupEnvironment(new CaveLevelElementFactory());
SetupEnvironment(new HauntedHouseLevelElementFactory());
