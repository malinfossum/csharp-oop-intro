namespace CsharpOopIntro;

// Modul 3: Organ Transplant
public class OrganTransplant
{
    public void Run()
    {
        // Scenario: Bernt trenger en ny nyre. Fetteren Kåre har to friske
        // nyrer som er testet kompatible med Bernt.
        var bernt = new Patient("Bernt", "akutt nyresvikt etter ulykke");
        var kare = new Donor("Kåre", "fetter");

        kare.LeggTilNyre(new Kidney(isHealthy: true, compatibleWith: bernt));
        kare.LeggTilNyre(new Kidney(isHealthy: true, compatibleWith: bernt));

        Console.WriteLine("--- Før transplantasjon ---");
        bernt.SkrivUtInfo();
        kare.SkrivUtInfo();
        foreach (var nyre in kare.Kidneys)
        {
            nyre.SkrivUtInfo();
        }
        Console.WriteLine();

        Console.WriteLine("--- Transplantasjon ---");
        var donertNyre = kare.GiBortNyre();
        if (donertNyre != null)
        {
            bernt.MottaNyre(donertNyre);
        }
        else
        {
            Console.WriteLine("Ingen nyrer tilgjengelig fra donor.");
        }
        Console.WriteLine();

        Console.WriteLine("--- Etter transplantasjon ---");
        bernt.SkrivUtInfo();
        kare.SkrivUtInfo();
    }
}
