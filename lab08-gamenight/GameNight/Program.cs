const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

// Look for the data files next to Program.cs, however the program is started.
string projectFolder = Path.GetFullPath(
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);

int leader = LeaderIndex(points);

System.Console.WriteLine("PLAYERS".PadRight(10) + "POINTS");
for (int i = 0; i < players.Length; i++) // Use .Count if they are Lists
{
    System.Console.WriteLine(players[i].PadRight(10) + points[i]);
}
System.Console.WriteLine($"Leader: {players[leader]} with {points[leader]}");
System.Console.WriteLine("Season total: " + TotalPoints(points));

//methods
static int LeaderIndex(string[] points)
{
    int leader = 0;
    for (int i = 1; i < points.Length; i++)
    {
        if (int.Parse(points[i]) > int.Parse(points[leader]))
        {
            leader = i;
        }
    }
    return leader;
}


static int TotalPoints(string[] points)
{
    int totalPoint = 0;
    foreach(string point in points)
    {
        totalPoint += int.Parse(point);
    }
    return totalPoint;
}