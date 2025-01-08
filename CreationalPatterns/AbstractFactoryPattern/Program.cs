using AbstractFactoryPattern.CaveLevel;
using AbstractFactoryPattern.Common;
using AbstractFactoryPattern.HauntedHouseLevel;

void SetupEnvironment(ILevelElementFactory levelFactory)
{
    var enemy = levelFactory.CreateEnemy();
    var weapon = levelFactory.CreateWeapon();
    var power = levelFactory.CreatePower();

    // ..
}

SetupEnvironment(new CaveLevelElementFactory());
SetupEnvironment(new HauntedHouseLevelElementFactory());