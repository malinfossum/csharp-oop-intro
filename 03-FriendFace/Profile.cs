namespace CsharpOopIntro;

// Modul 3: Sosiale medier (FriendFace) — Profil
public class Profile
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Bio { get; private set; }
    public string Location { get; private set; }
    public List<string> Interests { get; }
    public List<Profile> Friends { get; } = new();

    public Profile(string name, int age, string bio, string location, List<string> interests)
    {
        Name = name;
        Age = age;
        Bio = bio;
        Location = location;
        Interests = interests;
    }

    public void AddFriend(Profile friend)
    {
        if (Friends.Contains(friend))
        {
            Console.WriteLine($"{friend.Name} er allerede en venn.");
            return;
        }
        Friends.Add(friend);
        Console.WriteLine($"{friend.Name} er lagt til som venn.");
    }

    public void RemoveFriend(Profile friend)
    {
        if (!Friends.Contains(friend))
        {
            Console.WriteLine($"{friend.Name} er ikke en venn.");
            return;
        }
        Friends.Remove(friend);
        Console.WriteLine($"{friend.Name} er fjernet som venn.");
    }

    public void ListFriends()
    {
        if (Friends.Count == 0)
        {
            Console.WriteLine($"{Name} har ingen venner ennå.");
            return;
        }

        Console.WriteLine($"{Name} har {Friends.Count} venn(er):");
        for (int i = 0; i < Friends.Count; i++)
        {
            Console.WriteLine($"  {i + 1} - {Friends[i].Name}");
        }
    }

    public void SkrivUtInfo()
    {
        string interests = Interests.Count > 0 ? string.Join(", ", Interests) : "ingen registrerte";
        Console.WriteLine($"Profile: {Name} ({Age}) — {Location}");
        Console.WriteLine($"  Bio: {Bio}");
        Console.WriteLine($"  Interests: {interests}");
        Console.WriteLine($"  Friends: {Friends.Count}");
    }
}
