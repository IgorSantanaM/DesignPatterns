using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class InjuredState : ICharacterState
    {
        public void HandleDamage(Character character, int amount)
        {
            character.ModifyHealth(-(amount * 2));

            if(character.Health <= 0)
            {
                character.SetState(new DefeatedState());
            }
        }

        public void HandlePowerUpCollected(Character character)
        {
            character.ModifyHealth(50);
            character.SetState(new PowerUpState());
        }

        public void HandleUpdate(Character character)
        {
            character.ModifyHealth(2);

            if(character.Health >= 30)
            {
                character.SetState(new NormalState());
            }
        }
    }
}
