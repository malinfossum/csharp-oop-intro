namespace CsharpOopIntro;

// Modul 3: Organ Transplant — Donor
public class Donor
{
    public string Name { get; set; }
    public string Relasjon { get; set; }
    public List<Kidney> Kidneys { get; } = new();

    public Donor(string name, string relasjon)
    {
        Name = name;
        Relasjon = relasjon;
    }

    public void LeggTilNyre(Kidney nyre)
    {
        Kidneys.Add(nyre);
    }

    public Kidney? GiBortNyre()
    {
        if (Kidneys.Count == 0)
        {
            return null;
        }
        var nyre = Kidneys[0];
        Kidneys.RemoveAt(0);
        return nyre;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Donor: {Name} ({Relasjon}) — har {Kidneys.Count} nyre(r) igjen");
    }
}
