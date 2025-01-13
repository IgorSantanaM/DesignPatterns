using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PowerUpState : ICharacterState
    {

        private int powerUpDuration = 10    ;
        public void HandleDamage(Character character, int amount)
        {
            character.ModifyHealth(-(amount / 2));

            if(character.Health < 30)
            {
                character.SetState(new InjuredState());
            }
        }

        public void HandlePowerUpCollected(Character character)
        {
            powerUpDuration = 10;
        }

        public void HandleUpdate(Character character)
        {
            powerUpDuration--;
            if(powerUpDuration <= 1)
            {
                character.SetPowerUp(false);
                character.SetState(new NormalState());  
            }
        }
    }
}
