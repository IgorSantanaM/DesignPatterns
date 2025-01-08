using AbstractFactoryPattern.Common;

namespace AbstractFactoryPattern.HauntedHouseLevel
{
    public class HauntedHouseLevelElementFactory : ILevelElementFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Ghost();
        }

        public IPower CreatePower()
        {
            return new Orb();
        }

        public IWeapon CreateWeapon()
        {
            return new Staff();
        }
    }
}
