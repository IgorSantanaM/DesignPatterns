using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ScoreUI(Player player) : IGameObserver
    {

        private readonly Player _player = player;
        public void Update()
        {
            var score = _player.GetScore();

            Console.WriteLine($"player's score: {score}");
        }
    }
}
