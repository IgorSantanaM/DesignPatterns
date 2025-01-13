using State;

Character hero = new();

Console.WriteLine($"Initial Health: {hero.Health}");

hero.TakeDamage(30);
Console.WriteLine($"After first damage: {hero.Health}");

hero.CollectPowerUp(30);
Console.WriteLine($"After power up: {hero.Health}, has powerup {hero.HasPowerUp}");

hero.TakeDamage(30);
Console.WriteLine($"After second damage: {hero.Health}");

for(int i = 0; i < 12; i++)
{
    hero.Update();
}

Console.WriteLine($"After 12 ticks: {hero.Health}");

hero.TakeDamage(70);
Console.WriteLine($"After third damage: {hero.Health}");

