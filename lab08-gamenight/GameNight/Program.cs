/*
* Name: Angel Goldsmith
* Course: CSCI 1250, Section 001
* Assignment: Lab 08, Game Night
* Date: November 22, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

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

//Part 1

int leader = LeaderIndex(points);

System.Console.WriteLine("PLAYERS".PadRight(10) + "POINTS");
for (int i = 0; i < players.Length; i++) // Use .Count if they are Lists
{
    System.Console.WriteLine(players[i].PadRight(10) + points[i]);
}
System.Console.WriteLine($"Leader: {players[leader]} with {points[leader]}");
System.Console.WriteLine("Season total: " + TotalPoints(points));

System.Console.WriteLine(" ");
//Part 2

// int ada;
// int grace;
// int alan;
// int katherine;

// Console.Write("Points tonight for Ada: ");
// ada = Convert.ToInt32(Console.ReadLine());
// while (ada < 0 || ada > 20)
// {
//     Console.WriteLine("Points must be from 0 to 20.");
//     Console.Write("Points tonight for Ada: ");
//     ada = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Points tonight for Grace: ");
// grace = Convert.ToInt32(Console.ReadLine());
// while (grace < 0 || grace > 20)
// {
//     Console.WriteLine("Points must be from 0 to 20.");
//     Console.Write("Points tonight for Grace: ");
//     grace = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Points tonight for Alan: ");
// alan = Convert.ToInt32(Console.ReadLine());
// while (alan < 0 || alan > 20)
// {
//     Console.WriteLine("Points must be from 0 to 20.");
//     Console.Write("Points tonight for Alan: ");
//     alan = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Points tonight for Katherine: ");
// katherine = Convert.ToInt32(Console.ReadLine());
// while (katherine < 0 || katherine > 20)
// {
//     Console.WriteLine("Points must be from 0 to 20.");
//     Console.Write("Points tonight for Katherine: ");
//     katherine = Convert.ToInt32(Console.ReadLine());
// }
int winnerScore = 0;
string winnerName = "";

for (int i = 0; i < players.Length; i++) // Use .Count if they are Lists
{
    System.Console.Write("Points tonight for " + players[i] +":");
    int tonight = Convert.ToInt32(Console.ReadLine());

    while (tonight < 0 || tonight > 20)
    {
        System.Console.WriteLine("Points must be from 0 to 20.");
        System.Console.Write("Points tonight for " + players[i] +":");
        tonight = Convert.ToInt32(Console.ReadLine());
    }
    int season = Convert.ToInt32(points[i]) + tonight;
    points[i] = season.ToString();

    if(tonight>winnerScore)
    {
        winnerScore = tonight;
        winnerName = players[i];
    }

}
System.Console.WriteLine($"Tonight's winner: {winnerName} with {winnerScore}");
File.WriteAllLines(POINTS_FILE, points);

System.Console.WriteLine("Saved points.txt.");

//Part 3



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