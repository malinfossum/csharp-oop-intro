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

        var aliceOop = new Grade(alice, oop, 5);
        var aliceMath = new Grade(alice, math, 4);

        Console.WriteLine("--- Students ---");
        alice.SkrivUtInfo();
        bjorn.SkrivUtInfo();
        Console.WriteLine();

        Console.WriteLine("--- Subjects ---");
        oop.SkrivUtInfo();
        math.SkrivUtInfo();
        Console.WriteLine();

        Console.WriteLine("--- Grades ---");
        aliceOop.SkrivUtInfo();
        aliceMath.SkrivUtInfo();
    }
}
