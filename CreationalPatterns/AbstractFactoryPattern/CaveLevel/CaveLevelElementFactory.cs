using AbstractFactoryPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.CaveLevel
{
    public class CaveLevelElementFactory : ILevelElementFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Goblin();
        }

        public IPower CreatePower()
        {
            return new Crystal();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
