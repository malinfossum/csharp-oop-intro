namespace CsharpOopIntro;

// Modul 3: Studentadministrasjon — main flow
public class StudentAdministration
{
    public void Run()
    {
        // Del 2: create at least two of each class and call SkrivUtInfo
        var alice = new Student("Alice Eriksen", 22, "Informatikk", 1001);
        var bjorn = new Student("Bjørn Hansen", 24, "Informatikk", 1002);

        var oop = new Subject("PROG101", "Objektorientert programmering", 10);
        var math = new Subject("MAT100", "Diskret matematikk", 7);
        var db = new Subject("DB101", "Databaser", 5);

        // Del 3: register subjects and grades on each student
        alice.AddSubject(oop);
        alice.AddSubject(math);
        alice.AddSubject(db);
        alice.AddGrade(new Grade(alice, oop, 5));
        alice.AddGrade(new Grade(alice, math, 4));
        alice.AddGrade(new Grade(alice, db, 6));

        bjorn.AddSubject(oop);
        bjorn.AddSubject(math);
        bjorn.AddGrade(new Grade(bjorn, oop, 3));
        bjorn.AddGrade(new Grade(bjorn, math, 4));

        Console.WriteLine("--- Students ---");
        alice.SkrivUtInfo();
        bjorn.SkrivUtInfo();
        Console.WriteLine();

        Console.WriteLine("--- Subjects ---");
        oop.SkrivUtInfo();
        math.SkrivUtInfo();
        db.SkrivUtInfo();
        Console.WriteLine();

        Console.WriteLine("--- Grades ---");
        foreach (var grade in alice.Grades)
        {
            grade.SkrivUtInfo();
        }
        foreach (var grade in bjorn.Grades)
        {
            grade.SkrivUtInfo();
        }
        Console.WriteLine();

        Console.WriteLine("--- Averages and total credits ---");
        Console.WriteLine($"{alice.Name}: average {alice.AverageGrade():F2}, total {alice.TotalCredits()} credits");
        Console.WriteLine($"{bjorn.Name}: average {bjorn.AverageGrade():F2}, total {bjorn.TotalCredits()} credits");
    }
}
