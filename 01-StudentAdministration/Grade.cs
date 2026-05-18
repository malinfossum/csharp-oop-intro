namespace CsharpOopIntro;

// Modul 3: Studentadministrasjon — Karakter
public class Grade
{
    public Student Student { get; set; }
    public Subject Subject { get; set; }
    public int Value { get; set; }

    public Grade(Student student, Subject subject, int value)
    {
        Student = student;
        Subject = subject;
        Value = value;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Grade: {Student.Name} got {Value} in {Subject.Name}");
    }
}
