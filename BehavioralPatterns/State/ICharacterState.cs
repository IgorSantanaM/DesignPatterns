using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface ICharacterState
    {
        void HandleUpdate(Character character);
        void HandlePowerUpCollected(Character character);
        void HandleDamage(Character character, int amount);
    }
}
