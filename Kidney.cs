namespace CsharpOopIntro;

// Modul 3: Organ Transplant — Nyre
public class Kidney
{
    public bool IsHealthy { get; set; }
    public Patient? CompatibleWith { get; set; }

    public Kidney(bool isHealthy, Patient? compatibleWith)
    {
        IsHealthy = isHealthy;
        CompatibleWith = compatibleWith;
    }

    public bool IsCompatibleWith(Patient patient)
    {
        return CompatibleWith == patient;
    }

    public void SkrivUtInfo()
    {
        string helse = IsHealthy ? "frisk" : "syk";
        string kompat = CompatibleWith != null ? $"testet kompatibel med {CompatibleWith.Name}" : "ikke kompatibel";
        Console.WriteLine($"Kidney: {helse}, {kompat}");
    }
}
