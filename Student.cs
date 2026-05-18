namespace CsharpOopIntro;

// Modul 3: Studentadministrasjon
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Program { get; set; }
    public int StudentId { get; set; }
    public List<Subject> Subjects { get; } = new();
    public List<Grade> Grades { get; } = new();

    public Student(string name, int age, string program, int studentId)
    {
        Name = name;
        Age = age;
        Program = program;
        StudentId = studentId;
    }

    public void AddSubject(Subject subject)
    {
        Subjects.Add(subject);
    }

    public void AddGrade(Grade grade)
    {
        Grades.Add(grade);
    }

    // Gjennomsnittkarakter — foreach used instead of LINQ Average (Modul 6 topic)
    public double AverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (var grade in Grades)
        {
            sum += grade.Value;
        }
        return (double)sum / Grades.Count;
    }

    // Totalt antall studiepoeng — foreach used instead of LINQ Sum (Modul 6 topic)
    public int TotalCredits()
    {
        int total = 0;
        foreach (var subject in Subjects)
        {
            total += subject.Credits;
        }
        return total;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Student: {Name} ({Age}), {Program}, ID {StudentId}");
    }
}
