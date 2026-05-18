namespace CsharpOopIntro;

// Modul 3: Organ Transplant — Pasient
public class Patient
{
    public string Name { get; set; }
    public string Diagnose { get; set; }
    public bool HasReceivedKidney { get; private set; }
    public bool IsAlive { get; private set; } = true;

    public Patient(string name, string diagnose)
    {
        Name = name;
        Diagnose = diagnose;
    }

    public void MottaNyre(Kidney nyre)
    {
        if (nyre.IsHealthy && nyre.IsCompatibleWith(this))
        {
            HasReceivedKidney = true;
            Console.WriteLine($"Transplantasjon vellykket. {Name} har mottatt en frisk og kompatibel nyre.");
        }
        else
        {
            IsAlive = false;
            string grunn = !nyre.IsHealthy ? "nyren er ikke frisk" : "nyren er ikke kompatibel";
            Console.WriteLine($"Transplantasjon mislyktes ({grunn}). {Name} overlevde ikke.");
        }
    }

    public void SkrivUtInfo()
    {
        string status = HasReceivedKidney ? "overlever" : (IsAlive ? "venter på donor" : "døde");
        Console.WriteLine($"Patient: {Name} — {Diagnose} — status: {status}");
    }
}
