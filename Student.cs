namespace CsharpOopIntro;

// Modul 3: Studentadministrasjon
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Program { get; set; }
    public int StudentId { get; set; }

    public Student(string name, int age, string program, int studentId)
    {
        Name = name;
        Age = age;
        Program = program;
        StudentId = studentId;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Student: {Name} ({Age}), {Program}, ID {StudentId}");
    }
}
