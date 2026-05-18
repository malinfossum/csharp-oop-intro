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
                "Ingrid", 33,
                "Journalist og podkast-vert",
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

        var loggedIn = allUsers[0];

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== FriendFace — innlogget som {loggedIn.Name} ===");
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
                case "1": AddFriendPrompt(loggedIn, allUsers); break;
                case "2": RemoveFriendPrompt(loggedIn); break;
                case "3": ListFriends(loggedIn); break;
                case "4": ViewFriendProfilePrompt(loggedIn); break;
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

    private void AddFriendPrompt(Profile loggedIn, List<Profile> allUsers)
    {
        // Kandidater = alle i hovedlista som verken er hovedbrukeren selv
        // eller allerede i vennelista.
        var candidates = new List<Profile>();
        foreach (var user in allUsers)
        {
            if (user != loggedIn && !loggedIn.Friends.Contains(user))
            {
                candidates.Add(user);
            }
        }

        if (candidates.Count == 0)
        {
            Console.WriteLine("Ingen flere brukere å legge til.");
            return;
        }

        Console.WriteLine("Velg en bruker å legge til som venn:");
        for (int i = 0; i < candidates.Count; i++)
        {
            Console.WriteLine($"  {i + 1} - {candidates[i].Name}");
        }
        Console.Write("Nummer: ");

        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= candidates.Count)
        {
            loggedIn.AddFriend(candidates[choice - 1]);
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    private void RemoveFriendPrompt(Profile loggedIn)
    {
        if (loggedIn.Friends.Count == 0)
        {
            Console.WriteLine("Du har ingen venner å fjerne.");
            return;
        }

        Console.WriteLine("Velg en venn å fjerne:");
        for (int i = 0; i < loggedIn.Friends.Count; i++)
        {
            Console.WriteLine($"  {i + 1} - {loggedIn.Friends[i].Name}");
        }
        Console.Write("Nummer: ");

        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= loggedIn.Friends.Count)
        {
            loggedIn.RemoveFriend(loggedIn.Friends[choice - 1]);
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    private void ListFriends(Profile loggedIn)
    {
        if (loggedIn.Friends.Count == 0)
        {
            Console.WriteLine("Du har ingen venner ennå.");
            return;
        }

        Console.WriteLine($"Dine venner ({loggedIn.Friends.Count}):");
        foreach (var friend in loggedIn.Friends)
        {
            Console.WriteLine($"  - {friend.Name}");
        }
    }

    private void ViewFriendProfilePrompt(Profile loggedIn)
    {
        if (loggedIn.Friends.Count == 0)
        {
            Console.WriteLine("Du har ingen venner å vise profil for.");
            return;
        }

        Console.WriteLine("Velg en venn å se profilen til:");
        for (int i = 0; i < loggedIn.Friends.Count; i++)
        {
            Console.WriteLine($"  {i + 1} - {loggedIn.Friends[i].Name}");
        }
        Console.Write("Nummer: ");

        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= loggedIn.Friends.Count)
        {
            Console.WriteLine();
            loggedIn.Friends[choice - 1].SkrivUtInfo();
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }
}
