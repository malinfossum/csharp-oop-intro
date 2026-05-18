using CsharpOopIntro;

Run();

void Run()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=== csharp-oop-intro ===");
        Console.WriteLine();
        Console.WriteLine("1 - Student Administration");
        Console.WriteLine("2 - Organ Transplant");
        Console.WriteLine("3 - FriendFace (Social Media)");
        Console.WriteLine("4 - Bossfight");
        Console.WriteLine("0 - Exit");
        Console.WriteLine();
        Console.Write("Choose: ");

        var input = Console.ReadLine();
        Console.WriteLine();

        switch (input)
        {
            case "1": new StudentAdministration().Run(); break;
            case "2": new OrganTransplant().Run(); break;
            case "3": new FriendFace().Run(); break;
            case "4": new Bossfight().Run(); break;
            case "0": return;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
