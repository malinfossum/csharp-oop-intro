namespace CsharpOopIntro;

// Modul 3: Bossfight
public class Bossfight
{
    public void Run()
    {
        var hero = new GameCharacter("Hero", health: 100, strength: 20, stamina: 40);
        var enemy = new GameCharacter("Enemy", health: 400, minStrength: 0, maxStrength: 20, stamina: 10);

        Console.WriteLine($"{hero.Name} ({hero.Health} HP) vs {enemy.Name} ({enemy.Health} HP)");
        Console.WriteLine();

        while (hero.Health > 0 && enemy.Health > 0)
        {
            TakeTurn(hero, enemy);
            if (enemy.Health == 0)
            {
                break;
            }
            TakeTurn(enemy, hero);
        }

        Console.WriteLine();
        var winner = hero.Health > 0 ? hero.Name : enemy.Name;
        Console.WriteLine($"{winner} is the winner!");
    }

    private void TakeTurn(GameCharacter attacker, GameCharacter defender)
    {
        if (attacker.Stamina == 0)
        {
            attacker.Recharge();
        }
        else
        {
            attacker.Fight(defender);
        }
    }
}
