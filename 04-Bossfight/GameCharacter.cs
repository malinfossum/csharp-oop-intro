namespace CsharpOopIntro;

// Modul 3: Bossfight — GameCharacter
public class GameCharacter
{
    private static readonly Random _random = new();
    private readonly int _startingStamina;
    private readonly int _minStrength;
    private readonly int _maxStrength;

    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }
    public int Stamina { get; private set; }

    // Fast styrke (Hero).
    public GameCharacter(string name, int health, int strength, int stamina)
        : this(name, health, strength, strength, stamina)
    {
    }

    // Variabel styrke (Boss).
    public GameCharacter(string name, int health, int minStrength, int maxStrength, int stamina)
    {
        Name = name;
        Health = health;
        _minStrength = minStrength;
        _maxStrength = maxStrength;
        Strength = minStrength;
        Stamina = stamina;
        _startingStamina = stamina;
    }

    public void Fight(GameCharacter opponent)
    {
        if (_minStrength != _maxStrength)
        {
            // Random.Next er eksklusiv på øvre grense, så +1 for å inkludere maxStrength.
            Strength = _random.Next(_minStrength, _maxStrength + 1);
        }

        int damage = Strength;
        opponent.Health -= damage;
        if (opponent.Health < 0)
        {
            opponent.Health = 0;
        }
        Stamina -= 10;

        Console.WriteLine(
            $"{Name} hit {opponent.Name.ToLower()} with {damage} damage, " +
            $"{opponent.Name.ToLower()} now has {opponent.Health} health left.");
    }

    public void Recharge()
    {
        Stamina = _startingStamina;
        Console.WriteLine($"{Name} has no stamina and recharges (no damage dealt).");
    }
}
