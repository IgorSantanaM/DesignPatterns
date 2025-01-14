using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class HealthBarUI(Player player) : IGameObserver
    {
        private readonly Player _player = player;
        public void Update()
        {
            var health = _player.GetHealth();

            Console.WriteLine($"player's health: {health}");
        }
    }
}
