using Observer;

Player player = new();

player.Attach(new GameOverScreen(player));
player.Attach(new HealthBarUI(player));
player.Attach(new ScoreUI(player));

player.SetState(health: 100, score: 0);
player.SetState(health: 100, score: 10);
player.SetState(health: 90, score: 20);
player.SetState(health: 70, score: 30);
player.SetState(health: 50, score: 40);
player.SetState(health: 0, score: 40);