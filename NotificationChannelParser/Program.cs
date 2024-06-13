// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

while (true)
{
    Console.Write("Input: ");
    var title = Console.ReadLine();
    var validChannels = new List<string> { "BE", "FE", "QA", "Urgent" };
    var tags = Regex.Matches(title, @"\[([^]]+)\]").Select(x => x.Groups[1].Value).ToList();
    var channels = tags.Where(x => validChannels.Contains(x)).ToList();
    Console.WriteLine($"Output: Receive channels: {string.Join(", ", channels)}");
    Console.WriteLine("");
}
