using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DefeatedState : ICharacterState
    {
        public void HandleDamage(Character character, int amount)
        {
        }

        public void HandlePowerUpCollected(Character character)
        {
        }

        public void HandleUpdate(Character character)
        {
        }
    }
}
