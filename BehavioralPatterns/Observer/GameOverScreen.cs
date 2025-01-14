using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class GameOverScreen(Player player) : IGameObserver
    {

        private readonly Player _player = player;
        public void Update()
        {
            var health = _player.GetHealth();

            if(health <= 0)
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
