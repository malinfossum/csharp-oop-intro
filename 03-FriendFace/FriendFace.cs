namespace CsharpOopIntro;

// Modul 3: Sosiale medier (FriendFace)
public class FriendFace
{
    public void Run()
    {
        // Hovedlista: alle brukere som lever på FriendFace.
        // Hovedbrukeren (innlogget) er allUsers[0]. Vennlistene holder referanser
        // til de samme objektene — å fjerne en venn tar bort referansen, men selve
        // brukeren ligger fortsatt i hovedlista.
        var allUsers = new List<Profile>
        {
            new Profile(
                "Hovedbruker", 33,
                "Journalist og podcast-vert",
                "Oslo",
                new List<string> { "politikk", "podcaster", "løping" }),
            new Profile(
                "Anne", 28,
                "Lærer i grunnskolen",
                "Bergen",
                new List<string> { "bøker", "yoga", "vandring" }),
            new Profile(
                "Henrik", 42,
                "Ingeniør og pappa",
                "Trondheim",
                new List<string> { "fjellski", "elektronikk" }),
            new Profile(
                "Tora", 35,
                "Lege og fotograf",
                "Tromsø",
                new List<string> { "fotografi", "nordlys", "kajakk" }),
            new Profile(
                "Bjørn", 24,
                "Student i informatikk",
                "Stavanger",
                new List<string> { "gaming", "musikk", "matlaging" })
        };

        var loggedIn = new LoggedInUser(allUsers[0], allUsers);
        SeedDemoFriends(loggedIn, allUsers);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== FriendFace — innlogget som {loggedIn.Profile.Name} ===");
            Console.WriteLine();
            Console.WriteLine("1 - Legg til venn");
            Console.WriteLine("2 - Fjern venn");
            Console.WriteLine("3 - List venner");
            Console.WriteLine("4 - Vis profil for en venn");
            Console.WriteLine("0 - Tilbake");
            Console.WriteLine();
            Console.Write("Velg: ");

            var input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1": loggedIn.AddFriend(); break;
                case "2": loggedIn.RemoveFriend(); break;
                case "3": loggedIn.ListFriends(); break;
                case "4": loggedIn.ViewFriendProfile(); break;
                case "0": return;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Trykk en tast for å fortsette...");
            Console.ReadKey();
        }
    }

    private void SeedDemoFriends(LoggedInUser loggedIn, List<Profile> allUsers)
    {
        // Forhåndsfyll noen venner så vi slipper å klikke oss gjennom menyen
        // for å teste alle valg. Console.Clear() i loopen rydder utskriften
        // før første meny vises.
        loggedIn.Profile.AddFriend(allUsers[1]);
        loggedIn.Profile.AddFriend(allUsers[2]);
    }
}

