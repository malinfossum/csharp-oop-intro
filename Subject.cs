namespace CsharpOopIntro;

// Modul 3: Studentadministrasjon — Fag
public class Subject
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }

    public Subject(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Subject: {Code} - {Name} ({Credits} credits)");
    }
}
