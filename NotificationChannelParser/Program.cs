// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

while (true)
{
    Console.Write("Input: ");
    var title = Console.ReadLine();
    var validChannel = new List<string> { "BE", "FE", "QA", "Urgent" };
    var tags = Regex.Matches(title, @"\[([^]]+)\]").Select(x => x.Groups[1].Value).ToList();
    var channels = new List<string>();
    foreach (var tag in tags)
    {
        if (validChannel.Contains(tag))
        {
            channels.Add(tag);
        }
    }
    Console.WriteLine($"Output: Receive channels: {string.Join(", ", channels)}");
    Console.WriteLine("");
}
