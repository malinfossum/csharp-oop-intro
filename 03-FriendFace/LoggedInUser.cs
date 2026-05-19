namespace CsharpOopIntro;

// Modul 3: Sosiale medier (FriendFace) — Innlogget bruker.
// Holder en referanse til Profile-en som er innlogget + master-lista,
// og eier handlingene den brukeren gjør i denne sessionen.
public class LoggedInUser
{
    public Profile Profile { get; }
    private readonly List<Profile> _allUsers;

    public LoggedInUser(Profile profile, List<Profile> allUsers)
    {
        Profile = profile;
        _allUsers = allUsers;
    }

    public void AddFriend()
    {
        // Kandidater = alle i hovedlista som verken er meg selv eller allerede er venn.
        var candidates = new List<Profile>();
        foreach (var user in _allUsers)
        {
            if (user != Profile && !Profile.Friends.Contains(user))
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
            Profile.AddFriend(candidates[choice - 1]);
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    public void RemoveFriend()
    {
        var friend = SelectFriend("Velg en venn å fjerne:");
        if (friend is null)
        {
            return;
        }
        Profile.RemoveFriend(friend);
    }

    public void ListFriends()
    {
        Profile.ListFriends();
    }

    public void ViewFriendProfile()
    {
        var friend = SelectFriend("Velg en venn å se profilen til:");
        if (friend is null)
        {
            return;
        }
        Console.WriteLine();
        friend.SkrivUtInfo();
    }

    private Profile? SelectFriend(string prompt)
    {
        if (Profile.Friends.Count == 0)
        {
            Console.WriteLine("Du har ingen venner ennå.");
            return null;
        }

        Console.WriteLine(prompt);
        for (int i = 0; i < Profile.Friends.Count; i++)
        {
            Console.WriteLine($"  {i + 1} - {Profile.Friends[i].Name}");
        }
        Console.Write("Nummer: ");

        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= Profile.Friends.Count)
        {
            return Profile.Friends[choice - 1];
        }

        Console.WriteLine("Ugyldig valg.");
        return null;
    }
}
