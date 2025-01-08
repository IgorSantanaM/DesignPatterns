using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Common
{
    public interface ILevelElementFactory
    {
        IEnemy CreateEnemy();
        IWeapon CreateWeapon();
        IPower CreatePower();
    }
}
